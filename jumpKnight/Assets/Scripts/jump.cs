using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	private KnightControlScript joomp;



	// Use this for initialization
	void Start () {
		joomp = FindObjectOfType<KnightControlScript> ();
	
	}
	
	// Update is called once per frame
	public void Update () {


	
	}

	public void jumpPls(){

		joomp.jumping ();

		}




}

