using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wingScore1 : MonoBehaviour {
	
	public float score = 0;
	public float distanceScore = 0;
	public Vector3 prevPos;
	public float calculatedDistance;
	public float oldPos = 0;
	public Text scoreText;
	
	void Awake()
	{
		prevPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		//calculatedDistance += (transform.position - prevPos).magnitude;
		//prevPos = transform.position;
		//distanceScore = Mathf.Round(calculatedDistance/10);   
		//score = Mathf.Round((float)(transform.position.x));
		
		score = Mathf.Round((float)((transform.position.x + 35.8)/2.41));
		
		if (score <= 0)
			score = 0;
		
		//print("The score is: " + score);
		scoreText.text = score.ToString () + "%";
		
	}
	
	//	void OnGUI(){
	//
	//		//GUILayout.Label (score.ToString ());
	//		GUI.Label(new Rect(Screen.width/2, Screen.height/1.1f, 100, 100), score.ToString());
	//	
	//
	//	}
}
