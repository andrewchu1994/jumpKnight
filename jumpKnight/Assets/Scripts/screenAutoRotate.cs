using UnityEngine;
using System.Collections;

public class screenAutoRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;
		Screen.orientation = ScreenOrientation.AutoRotation;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
