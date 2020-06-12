using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class clearPlayerPref : Button {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(IsPressed()){
			PlayerPrefs.DeleteAll();
		}

	
	}
}
