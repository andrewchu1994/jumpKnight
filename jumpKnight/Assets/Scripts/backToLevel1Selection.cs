using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class backToLevel1Selection : Button {



	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPressed ()) {
	
			Application.LoadLevel("lvl1SelectionScreen");

				}
	
	}
}
