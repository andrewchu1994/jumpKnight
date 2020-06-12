using UnityEngine;
using System.Collections;

public class goToLevel1Selection : MonoBehaviour {

	//private KnightControlScript knight;

	// Use this for initialization
	void Start () {
	
	//	knight = FindObjectOfType<KnightControlScript> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape)) {
	//		knight.bannerView.Destroy();
			Application.LoadLevel("lvl1SelectionScreen");
		}
	
	}
}
