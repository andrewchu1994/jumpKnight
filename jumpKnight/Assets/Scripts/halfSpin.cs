using UnityEngine;
using System.Collections;

public class halfSpin : MonoBehaviour {

	public float spinZ;
	public float x,y;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (x,y, spinZ);
		
	}
}
