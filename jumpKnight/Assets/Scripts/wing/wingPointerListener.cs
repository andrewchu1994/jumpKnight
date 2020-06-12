using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class wingPointerListener : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler, IPointerExitHandler
{
	public wingeMovementDirection Direction;
	public wingFunctions functions;
	
	bool _pressed = false;

	void Start(){
	
	}
	
	public void OnPointerDown(PointerEventData eventData)
	{
		_pressed = true;
		wingGlobalState._pressedDown = true;
	}
	
	public void OnPointerEnter(PointerEventData eventData)
	{
		if(wingGlobalState._pressedDown) {
			_pressed = true;
		}
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		_pressed = false;
		wingGlobalState._pressedDown = false;
	}
	
	public void OnPointerExit(PointerEventData eventData)
	{
		_pressed = false;
	}
	
	void Update()
	{

		if (!_pressed)
			return;
		
		switch(Direction)
		{
		case wingeMovementDirection.Up:
			break;
		case wingeMovementDirection.Down:
			break;
		case wingeMovementDirection.Left:
			functions.Left();
			break;
		case wingeMovementDirection.Right:
			functions.Right();
			break;
		}
	}
}

[System.Serializable]
public enum wingeMovementDirection
{
	Up, Down, Left, Right
}