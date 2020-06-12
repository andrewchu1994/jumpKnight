using UnityEngine;
using System.Collections;

public class spinning : MonoBehaviour {

	public float x,y,z;


	
	// Update is called once per frame
	void Update () {

		transform.Rotate (x, y, z);
	
	}
}
