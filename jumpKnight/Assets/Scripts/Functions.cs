using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {
	
	//public Transform player;
	private KnightControlScript knight;

	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
		
	}
	
	public void Left () {
		
		//Debug.Log("left");
		knight.moving (-1);
		
	}
	
	public void Right () {
		
		//Debug.Log("right");
		knight.moving (1);
		
	}
	
//	private void Move (float value) {
//		
//		float newX = player.position.x + value * Time.deltaTime;
//		player.position = new Vector3(newX, player.position.y, player.position.z);
//		
//	}
	
}
