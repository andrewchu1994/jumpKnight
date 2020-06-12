using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class level2KnightSelected : Button {
	
	public Animator anim;
	private bool stop = false;
	public bool disable = false;
	
	// Use this for initialization
	void Start () {
		
		anim = FindObjectOfType<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (IsPressed ()) {
			anim.SetTrigger ("selected2");
			StartCoroutine (waiting ());
			if(stop == false){
			gameObject.GetComponent<AudioSource> ().Play ();
				stop = true;
			}
			waiting();
			disable = true;
			
			
		}
		
	}
	
	IEnumerator waiting(){
		//anim.SetTrigger ("selected2");
		yield return new WaitForSeconds(0.5f);
		//gameObject.GetComponent<AudioSource> ().Play ();
		float fadeTime = GameObject.Find ("wingScreenBackground").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		yield return new WaitForSeconds(1.5f);
		Application.LoadLevel("lvl2SelectionScreen");
		
	}
	
	
}
