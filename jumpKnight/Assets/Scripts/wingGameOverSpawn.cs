using UnityEngine;
using System.Collections;

public class wingGameOverSpawn : MonoBehaviour {
	public GameObject gameOverText, block;
	public Rigidbody2D rig;
	private pausedScript button;
	private wingKnightController knight;
	bool stop = false;
	
	// Use this for initialization
	void Start () {
		knight = FindObjectOfType<wingKnightController> ();
		rig = gameOverText.GetComponent<Rigidbody2D> ();
		button = FindObjectOfType<pausedScript> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (knight.isDead == true && stop == false) {
			button.pauseButton.SetActive(false);
			Instantiate(block,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y, 0f), Quaternion.identity);
			Instantiate(gameOverText,new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y+8, 0f), Quaternion.identity);
			
			stop = true;
			
		}
		
		
	}
	
	
	
	
}



