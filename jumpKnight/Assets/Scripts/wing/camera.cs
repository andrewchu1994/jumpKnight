using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject player;

	public bool isFollowing;

	public float x;
	public float y;

	// Use this for initialization
	void Start () {
		//player = FindObjectOfType<wingKnightController> ();

		isFollowing = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isFollowing) {

			Vector3 camPos = transform.position;
			camPos.x = player.transform.position.x + x;
			camPos.y = player.transform.position.y + y;
			transform.position = camPos;

				}
	
	}
}
