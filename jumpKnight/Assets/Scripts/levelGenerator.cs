using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class levelGenerator : MonoBehaviour
{
	//public variables where we will place the 2 first pieces of the map
	public Transform first;
	public Transform second;
	//a queue object where we queue the level parts
	private Queue <Transform> piecesQueue = new Queue <Transform>();
	//an object array where we load all the level parts in the Start method
	private Object[] levelPieces;
	
	private bool levelstarted;
	//a list that will keep track of the active level parts in the scene
	private List<GameObject> activeParts = new List<GameObject>();
	private int activePartCount;
	
	private float distance;
	private Vector3 nextPosition;
	
	private bool remove;
	
	private Transform firstActive;
	private float distanceTraveled;
	//public variable to keep track of the player's location
	public Transform player;
	
	// Use this for initialization
	void Start ()
	{
		//Populate queue
		levelPieces = Resources.LoadAll<Transform>("Prefabs");
		piecesQueue.Enqueue(first);
		piecesQueue.Enqueue(second);
		firstActive = piecesQueue.Peek ();
		//ALLOW SHIT TO BE DONE
		levelstarted = true;
	}
	
	void GenerateLevel()
	{
		if (activePartCount < 10)
		{
			//The new piece which is added to the map
			Transform activatee = (Transform)Instantiate (piecesQueue.Dequeue ());
			//Add it to the activeParts list to keep track of everything
			activeParts.Add (activatee.gameObject);
			//Calculate the distance which we'll use to determine the location of the next piece
			distance = (activatee.GetComponent<Renderer>().bounds.size.x + piecesQueue.Peek ().GetComponent<Renderer>().bounds.size.x) / 2;
			//Move the position of the transform to the correct location
			activatee.localPosition = nextPosition;
			//Add one to the activeparts counter
			activePartCount++;
			//Count the location of the next piece
			nextPosition.x = nextPosition.x + distance;
			//Randomize the next piece from the levelPieces array and add it to the queue
			Transform addee = (Transform)levelPieces [Random.Range (0, levelPieces.Length)];
			piecesQueue.Enqueue(addee);
		}
	}
	
	void DeleteLevelPiece()
	{
		if (remove)
		{
			//Substract one from the activePart counter
			activePartCount--;
			//Get the first object which is now behind the player and so can be destroyed from the scene
			GameObject removee = activeParts[0];
			//Remove it from the list
			activeParts.RemoveAt (0);
			//Delete it from the scene
			Destroy (removee);
			//Get the new first active piece
			firstActive = activeParts[0].transform;
			//Stop the looping of this method
			remove = false;
		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Wait for queue to be populated
		if (levelstarted)
		{
			GenerateLevel ();
			DeleteLevelPiece ();
			//Calculate how far the player has traveled compared to the first active level piece
			distanceTraveled = player.transform.position.x - firstActive.localPosition.x;
			//If the player has travelled far enough delete the obsolete piece
			if(distanceTraveled > 100)
			{
				remove = true;
			}
		}
	}
} 