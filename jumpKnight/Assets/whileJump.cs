using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class whileJump :  MonoBehaviour, IPointerEnterHandler
{
	private KnightControlScript knight;
	
	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void OnPointerEnter (PointerEventData eventData){
		
		if(Input.GetMouseButton(0))
			knight.jumping ();
		
		//knight.jumping ();
		
	}
}

