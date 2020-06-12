﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class loadLevel2 : Button {
	
	public string level;
	public bool sign;
	
	// Use this for initialization
	void Start () {
		
		//		if(IsPressed()){
		//			Application.LoadLevel("beg");
		//		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(IsPressed()){
			StartCoroutine(changeLevel());
			this.GetComponent<AudioSource>().Play();
			sign = true;
			changeLevel();
		}
		
		
	}

	IEnumerator changeLevel(){
		yield return new WaitForSeconds (0.1f);
		
		float fadeTime = GameObject.Find ("lvl2_0").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		
		Application.LoadLevel("beg2");
		
		
	}
}