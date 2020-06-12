using UnityEngine;
using System.Collections;

public class classicSign : MonoBehaviour {

	private loadLevel1 lv1;
	private loadLevel2 lv2;
	private loadLevel3 lv3;

	public GameObject panel;

	// Use this for initialization
	void Start () {

		lv1 = FindObjectOfType<loadLevel1> ();
		lv2 = FindObjectOfType<loadLevel2> ();
		lv3 = FindObjectOfType<loadLevel3> ();
	

		panel.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (lv1.sign == true) {
						panel.SetActive (true);

				} else if (lv2.sign == true) {

						panel.SetActive (true);
				} else if (lv3.sign == true) {
						panel.SetActive (true);
				}

	}
}
