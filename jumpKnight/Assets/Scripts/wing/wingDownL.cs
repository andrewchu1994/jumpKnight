using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class wingDownL : Button{
	
	protected wingKnightController knight;
	
	
	void Start () {
		knight = FindObjectOfType<wingKnightController> ();
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