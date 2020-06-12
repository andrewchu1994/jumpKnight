using UnityEngine;
using System.Collections;

public class wingSign : MonoBehaviour {

	private loadLevel1wing wlv1;
	private loadLevel2Wing wlv2;
	private loadLevel3Wing wlv3;

	public GameObject panel;

	// Use this for initialization
	void Start () {

		wlv1 = FindObjectOfType<loadLevel1wing> ();
		wlv2 = FindObjectOfType <loadLevel2Wing> ();
		wlv3 = FindObjectOfType <loadLevel3Wing> ();
		
		panel.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (wlv1.sign == true) {
			panel.SetActive (true);
		} else if (wlv2.sign == true) {
			panel.SetActive (true);
		} else if (wlv3.sign == true) {
			panel.SetActive(true);
		}
	
	}
}
