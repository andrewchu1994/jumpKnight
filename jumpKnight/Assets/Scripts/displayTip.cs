using UnityEngine;
using System.Collections;

public class displayTip : MonoBehaviour {

	public GameObject tipButton, tipPanel;

	// Use this for initialization
	void Start () {

		tipPanel.SetActive (false);
		tipButton.SetActive (true);


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void showTip(){
		tipPanel.SetActive (true);
		tipButton.SetActive (false);
	}

	public void noShowTip(){
		tipPanel.SetActive (false);
		tipButton.SetActive(true);

		}
}
