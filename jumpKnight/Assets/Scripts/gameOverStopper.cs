using UnityEngine;
using System.Collections;

public class gameOverStopper : MonoBehaviour {
	
	public spawnGameOver gameOver;


	// Use this for initialization
	void Start () {

		gameOver = FindObjectOfType<spawnGameOver> ();

	}
	
	// Update is called once per frame
	void Update () {


	
	}

	public void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "block") {
			other.GetComponent<Rigidbody2D>().isKinematic = true;
			
		}
}
}