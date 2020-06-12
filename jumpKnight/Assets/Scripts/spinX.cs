using UnityEngine;
using System.Collections;

public class spinX : MonoBehaviour {

	public float spinZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (0,spinZ*Time.timeScale,0);
	
	}
}
