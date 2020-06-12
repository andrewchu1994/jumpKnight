using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class downL : Button{
	
	protected KnightControlScript knight;
	
	
	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
	}
	
	
	public void Update()
	{
		if(IsPressed())
		{
			WhilePressed();

		}
	}
	
	
	public void WhilePressed()
	{
				knight.moving (-1);
			

	}


	
}