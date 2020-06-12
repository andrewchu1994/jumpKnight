using UnityEngine;
using System.Collections;

public class cameraChanger : MonoBehaviour {

	public camera cam;
	public float ex, why;

	// Use this for initialization
	void Start () {

		cam = FindObjectOfType<camera> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			cam.x = ex;
			cam.y = why;
			this.gameObject.GetComponent<Collider2D>().enabled = false;
				}



	}

}
