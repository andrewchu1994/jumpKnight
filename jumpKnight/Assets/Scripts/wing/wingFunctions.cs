using UnityEngine;
using System.Collections;

public class wingFunctions : MonoBehaviour {
	
	//public Transform player;
	private wingKnightController knight;
	
	void Start () {
		knight = FindObjectOfType<wingKnightController> ();
		
	}
	
	public void Left () {
		
		//Debug.Log("left");
		knight.moving (-1);
		
	}
	
	public void Right () {
		
		//Debug.Log("right");
		knight.moving (1);
		
	}


//		if (knight.grounded)
//						knight.doubleJump = false;
//		if (knight.grounded && !knight.isDead) {
//
//						knight.jumping ();
//				}
//
//		if (!knight.doubleJump && !knight.grounded && !knight.isDead) {
//			knight.jumping();
//			knight.doubleJump = true;
//
//				}



	
	//	private void Move (float value) {
	//		
	//		float newX = player.position.x + value * Time.deltaTime;
	//		player.position = new Vector3(newX, player.position.y, player.position.z);
	//		
	//	}
	
}
