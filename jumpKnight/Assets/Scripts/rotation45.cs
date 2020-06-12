using UnityEngine;
using System.Collections;

public class rotation45 : MonoBehaviour {

	public int rotateZ = 5;

	// Use this for initialization
	void Start () {
		//RotateLeft ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (0, 0, rotateZ);

	}

	//void RotateLeft () {
		//transform.Rotate (Vector3.forward * 90);
	//
	

}
