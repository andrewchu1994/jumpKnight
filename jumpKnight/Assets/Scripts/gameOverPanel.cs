using UnityEngine;
using System.Collections;

public class gameOverPanel : MonoBehaviour {

	private KnightControlScript knight;
	public GameObject gameOverScreen;
	public bool stopper = false;


	// Use this for initialization
	void Start () {

		knight = FindObjectOfType<KnightControlScript> ();

		gameOverScreen.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine (wait ());
		wait ();
	
	}

	IEnumerator wait(){

		if (stopper == false && knight.isDead == true) {
			yield return new WaitForSeconds(1f);
			
			gameOverScreen.SetActive(true);
			stopper = true;
		}


	}


}
