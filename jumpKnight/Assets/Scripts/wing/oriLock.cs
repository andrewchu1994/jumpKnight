using UnityEngine;
using System.Collections;

public class oriLock : MonoBehaviour {

	public float spinZ;



	// Use this for initialization
	void Start () {
	
	} 	
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(new Vector3(0,0,spinZ));

	
	}

}
