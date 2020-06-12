using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour {

	public GameObject targetObject;
	
	private float distanceToTarget;
	private float distanceToTarget2;
	
	// Use this for initialization
	void Start () {
		distanceToTarget = transform.position.x - targetObject.transform.position.x;
		//distanceToTarget2 = transform.position.y - targetObject.transform.position.y + Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		float targetObjectX = targetObject.transform.position.x;
		//float targetObjectY = targetObject.transform.position.y;
		
		Vector3 newCameraPosition = transform.position;
		newCameraPosition.x = targetObjectX + distanceToTarget;
		//newCameraPosition.y = targetObjectY + distanceToTarget2;
		transform.position = newCameraPosition;    	
	}
}
