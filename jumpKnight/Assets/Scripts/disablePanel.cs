using UnityEngine;
using System.Collections;

public class disablePanel : MonoBehaviour {

	private level1KnightSelected knight;
	private level2KnightSelected knight2;
	public GameObject panel, panel2;
	private bool stop, stop2 = false;

	// Use this for initialization
	void Start () {

		knight = FindObjectOfType<level1KnightSelected> ();
		knight2 = FindObjectOfType<level2KnightSelected> ();
		panel.SetActive (false);
		panel2.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (knight.disable == true && stop == false) {

			panel.SetActive(true);

			stop = true;
				}

		else if(knight2.disable == true && stop2 == false){
			panel2.SetActive(true);

			stop2 = true;


		}
	
	}
}
