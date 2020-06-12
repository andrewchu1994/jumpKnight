using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragLeft : MonoBehaviour, IPointerEnterHandler
{
	private KnightControlScript knight;


	
	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
	
	
	}
	
	// Update is called once per frame
	void Update ()
	{

//		if(eventSystem.IsPointerOverGameObject ()) {
//			knight.moving (-1);
//			
//		}

//		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
//						// Get movement of the finger since last frame
//						//var touchDeltaPosition:Vector2 = Input.GetTouch(0).deltaPosition;
//
//			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
//						// Move object across XY plane
//			transform.Translate (touchDeltaPosition.x * 0.5f, 10f, 10f);
//				}

		
	}
	
	public void OnPointerEnter(PointerEventData eventData2){
		
		if (Input.GetMouseButton(0)) {
						knight.moving (-1);
				}

	}

}

