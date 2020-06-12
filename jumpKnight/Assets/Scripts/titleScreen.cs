using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class titleScreen : Button {

	private bool stopper = false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {


		if (IsPressed() && stopper == false) {

			StartCoroutine (changeLevel ());
			changeLevel();
			stopper = true;


				}
	
	}

	
	IEnumerator changeLevel(){
		//yield return new WaitForSeconds (1);
		gameObject.GetComponent<AudioSource>().Play();
		float fadeTime = GameObject.Find ("level1Select").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);

		Application.LoadLevel("scroll");
		
		
	}

}
