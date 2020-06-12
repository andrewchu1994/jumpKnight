using UnityEngine;
using System.Collections;

public class nextLevelScript : MonoBehaviour {
	
	public bool hasEnded = false;
	public string nextLevel;
	//public GameObject obj;
	public float seconds;
	public float delay;
	private Animator anim;




	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

//		if (hasEnded == true) {
//
//						StartCoroutine (changeLevel ());
//				}
//
//		
	}
	
	//Update is called once per frame
	void Update () {
//		
//		if (hasEnded) {
//
//			changeLevel();
//		}
		if (hasEnded == true) {
			
			StartCoroutine (changeLevel ());
			PlayerPrefs.SetInt("test1", 1);
			//knight.myrigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
			hasEnded = false;
		}
		
	}
//
	void OnTriggerEnter2D(Collider2D other){
				if (other.tag == "Player") {
			//this.gameObject.GetComponent<Collider2D>().enabled = false;
			anim.SetTrigger("dis");

			hasEnded = true;
		
				}
	}


	IEnumerator changeLevel(){
		yield return new WaitForSeconds (seconds);

		float fadeTime = GameObject.Find ("Character 4").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);

		Application.LoadLevel(nextLevel);


	}

	

}
