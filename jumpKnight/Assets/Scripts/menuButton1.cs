using UnityEngine;
using System.Collections;

public class menuButton1 : MonoBehaviour {

	public string nextLevel;
	public Sprite sprite1;
	//public Sprite sprite2;
	public SpriteRenderer spriteRenderer;

	void OnMouseDown(){

		Application.LoadLevel (nextLevel);
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = sprite1;

	}
}
