using UnityEngine;
using System.Collections;

public class touchControls : MonoBehaviour {

	private KnightControlScript knight;

	// Use this for initialization
	void Start () {
		knight = FindObjectOfType<KnightControlScript> ();
	
	}
	
	public void jumping(){

		knight.jumping ();
	

	}

	public void movingLeft(){

		knight.moving (-1);

		}
	public void movingRight(){
		
		knight.moving (1);
		
	}

	public void noMove(){

		knight.moving (0);

	}
	

}
