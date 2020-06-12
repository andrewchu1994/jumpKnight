using UnityEngine;
using System.Collections;

public class portalScript : MonoBehaviour {

	bool hasEnded;
	public string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (hasEnded) {

			Application.LoadLevel(nextLevel);
				}
	
	}

	void OnTriggerEvent2D(Collider2D other){
		if (other.tag == "Player") {
			hasEnded = true;
		}
		
		
		
	}
}
