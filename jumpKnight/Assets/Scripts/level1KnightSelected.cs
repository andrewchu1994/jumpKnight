using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class level1KnightSelected : Button {

	public Animator anim2;
	private bool stop = false;
	public bool disable = false;

	// Use this for initialization
	void Start () {

		anim2 = GameObject.FindGameObjectWithTag ("cat").GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPressed ()) {

			anim2.SetTrigger("act");	
			StartCoroutine (waiting2 ());
			if(stop == false){
			gameObject.GetComponent<AudioSource> ().Play();
				stop = true;
			}
			waiting2();
			disable = true;
		

				}
	
	}

	IEnumerator waiting2(){
		//anim2.SetInteger ("act", 2);
		yield return new WaitForSeconds(0.5f);

		float fadeTime = GameObject.Find ("wingScreen").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		yield return new WaitForSeconds(1.5f);
		Application.LoadLevel("lvl1SelectionScreen");

	}


}
