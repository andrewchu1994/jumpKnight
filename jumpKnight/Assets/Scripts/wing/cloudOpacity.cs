using UnityEngine;
using System.Collections;


public class cloudOpacity : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<SpriteRenderer>().color = new Color (1f, 1f, 1f, .4f);

	}
}
