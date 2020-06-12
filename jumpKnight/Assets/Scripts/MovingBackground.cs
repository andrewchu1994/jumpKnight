using UnityEngine;
using System.Collections;

public class MovingBackground : MonoBehaviour {
	public float MovingSpeed = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float offset = Time.time * MovingSpeed;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (offset,0);
	}
}
