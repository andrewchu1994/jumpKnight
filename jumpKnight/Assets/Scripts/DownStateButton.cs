using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DownStateButton : Button{

	private KnightControlScript knight;


	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
		
	}


	public void Update()
	{
////		//A public function in the selectable class which button inherits from.
		if(IsPressed())
		{
			WhilePressed();
		}
	}

	public void WhilePressed()
	{
				knight.jumping ();
		}

		
	}
