using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class resetScript : Button {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPressed ()) {

			Application.LoadLevel(Application.loadedLevel);

				}
	
	}
}
