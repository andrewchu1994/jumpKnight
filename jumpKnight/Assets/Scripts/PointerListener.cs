using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerUpHandler, IPointerExitHandler
{
	public eMovementDirection Direction;
	public Functions functions;
	
	bool _pressed = false;
	
	public void OnPointerDown(PointerEventData eventData)
	{
		_pressed = true;
		GlobalState._pressedDown = true;
	}
	
	public void OnPointerEnter(PointerEventData eventData)
	{
		if(GlobalState._pressedDown) {
			_pressed = true;
		}
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		_pressed = false;
		GlobalState._pressedDown = false;
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
		case eMovementDirection.Up:
			break;
		case eMovementDirection.Down:
			break;
		case eMovementDirection.Left:
			functions.Left();
			break;
		case eMovementDirection.Right:
			functions.Right();
			break;
		}
	}
}

[System.Serializable]
public enum eMovementDirection
{
	Up, Down, Left, Right
}