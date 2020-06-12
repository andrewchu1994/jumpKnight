using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class loadTy : Button {
	
	public string level;
	
	// Use this for initialization
	void Start () {
		
		//		if(IsPressed()){
		//			Application.LoadLevel("beg");
		//		}
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {

			Application.LoadLevel("thanksDemo");


				}

		}
}
