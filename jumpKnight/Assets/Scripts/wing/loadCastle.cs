using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class loadCastle : Button {
	
	public string level;
	
	// Use this for initialization
	void Start () {
		
		//		if(IsPressed()){
		//			Application.LoadLevel("beg");
		//		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(IsPressed()){
			Application.LoadLevel("scroll");
		}
		
		
	}
}
