using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class openTwitter : Button {

	private bool stop = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPressed () && stop == false) {

			Application.OpenURL("https://twitter.com/adotchu");
			stop = true;

				}
	
	
	}
}
