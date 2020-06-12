using UnityEngine;
using System.Collections;

public class nextLevelNoAnim : MonoBehaviour {
	
	public bool hasEnded = false;
	public string nextLevel;
	public float seconds;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (hasEnded == true) {
			
			StartCoroutine (changeLevel ());
			//knight.myrigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
			hasEnded = false;
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			PlayerPrefs.SetInt("wing1", 1);
			//this.gameObject.GetComponent<Collider2D>().enabled = false;
			
			hasEnded = true;
			
		}
	}
	
	IEnumerator changeLevel(){
		yield return new WaitForSeconds (seconds);
		
		float fadeTime = GameObject.Find ("Character 1").GetComponent<fadeScene> ().BeginFade (1);
		yield return new WaitForSeconds(fadeTime);
		
		Application.LoadLevel(nextLevel);
		
		
	}
	
}
