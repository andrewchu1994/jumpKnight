using UnityEngine;
using System.Collections;

public class endScreenAppear : MonoBehaviour {

	public GameObject levelText, complete, spinner, pauser;
	public float x,y,z;
	private bool stop = false;

	// Use this for initialization
	void Start () {

		levelText.SetActive (false);
		complete.SetActive (false);
		spinner.SetActive (false);
		pauser.SetActive (true);
	
	}
	
	// Update is called once per frame
	void Update () {
		if (stop == false) {
						StartCoroutine (endo ());
			endo();
						stop = true;
				}

	
	}

	IEnumerator endo(){

		yield return new WaitForSeconds(x);
		levelText.SetActive (true);
		yield return new WaitForSeconds (y);
		complete.SetActive (true);
		yield return new WaitForSeconds (z);
		spinner.SetActive (true);
		pauser.SetActive (false);


	}

	public void loadlvl1selection(){

		Application.LoadLevel("lvl1SelectionScreen");

	}

	public void loadlvl2selection(){
		
		Application.LoadLevel("lvl2SelectionScreen");
		
	}
}
