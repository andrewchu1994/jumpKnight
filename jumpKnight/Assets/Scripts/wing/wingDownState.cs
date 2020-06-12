using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class wingDownState : Button, IPointerDownHandler{
	
	private wingKnightController knight;
	public bool dJump;
	
	
	void Start () {
		knight = FindObjectOfType<wingKnightController> ();
		
	}
	
	
	public void Update()
	{
		////		//A public function in the selectable class which button inherits from.
//		if(IsPressed())
//		{
//			WhilePressed();
//		}
//		if (knight.grounded)
//						dJump = false;
//
//		if (knight.grounded && !knight.isDead && ) {
//			knight.jumping ();
//
//
//		}
//
//		if (!dJump && !knight.grounded && IsPressed() && !knight.isDead) {
//			knight.jumping ();
//			dJump = true;
//
//		
//		}

	}

	public void OnPointerDown(PointerEventData pointer){
				if (knight.grounded)
						dJump = false;

				if (knight.grounded && !knight.isDead) {
						knight.jumping ();
			IsPressed();
				}

				if (!dJump && !knight.grounded && !knight.isDead) {
						knight.jumping ();
						dJump = true;
			IsPressed();
				}

		}
	
//	public void WhilePressed()
//	{
//		knight.jumping ();
//	}
	
	
}
