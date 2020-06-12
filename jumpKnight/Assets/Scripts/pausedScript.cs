using UnityEngine;
using System.Collections;

public class pausedScript : MonoBehaviour {

	public GameObject pauseButton, pausePanel, controls, controls2, controlPanel;
	public KnightControlScript knight;
	public wingKnightController wingKnight;

	// Use this for initialization
	void Start () {
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;
		Screen.orientation = ScreenOrientation.AutoRotation;

		OnUnPause ();
		//PlayerPrefs.SetInt ("default", 0);
		//controls.SetActive (true);
		//controls2.SetActive (false);
		if (PlayerPrefs.GetInt ("default") == 0) {
			controls.SetActive (true);
			controls2.SetActive(false);
		} else if (PlayerPrefs.GetInt("default") == 1){
			controls2.SetActive (true);
			controls.SetActive(false);
		}
	
		controlPanel.SetActive (false);

		knight = FindObjectOfType<KnightControlScript> ();
		wingKnight = FindObjectOfType<wingKnightController> ();
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (PlayerPrefs.GetInt ("default") == 0) {
//			controls.SetActive (true);
//			controls2.SetActive(false);
//		} else if (PlayerPrefs.GetInt("default") == 1){
//			controls2.SetActive (true);
//			controls.SetActive(false);
//		}
	
	}

	public void OnPause(){

		pausePanel.SetActive (true);
		pauseButton.SetActive (false);
		Time.timeScale = 0;

	}

	public void OnUnPause(){
		pausePanel.SetActive (false);
		pauseButton.SetActive (true);
		Time.timeScale = 1;

	}

	public void backLevel1(){

		Application.LoadLevel ("lvl1SelectionScreen");
		Time.timeScale = 1;
	//	knight.bannerView.Destroy ();


	}

	public void backLevel2(){
		
		Application.LoadLevel ("lvl2SelectionScreen");
		Time.timeScale = 1;
	//	wingKnight.bannerView2.Destroy ();

		
	}

	public void restart(){

		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1;
	//	knight.bannerView.Destroy ();

	}

	public void wingRestart(){
		
		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1;
	//	wingKnight.bannerView2.Destroy ();
		
	}

	public void showControls(){
		pausePanel.SetActive (false);
		controlPanel.SetActive (true);

	}

	public void backToPause(){
		controlPanel.SetActive (false);
		pausePanel.SetActive (true);

	}

	public void setDefault(){
		PlayerPrefs.SetInt ("default", 0);
		controls.SetActive (true);
		controls2.SetActive (false);

	}

	public void setReverse(){
		PlayerPrefs.SetInt ("default", 1);
		controls.SetActive (false);
		controls2.SetActive (true);

	}

}
