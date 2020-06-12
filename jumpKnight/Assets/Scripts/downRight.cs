using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class downRight : Button{

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
		knight.moving (1);


	}

	
//	public void OnPointerEnter (PointerEventData eventData){
//		while (eventData.eligibleForClick == true) {
//			Debug.Log("pls");
//		}
//		
//	}

}