using UnityEngine;
using System.Collections;

public class blockSummon : MonoBehaviour {

	public GameObject block;
	public float x, y;
	//private GameObject testBox;



	// Use this for initialization
	void Start () {
		//testBox = FindObjectOfType<GameObject> ();
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {

			Instantiate(block, new Vector3(x,y,0f), Quaternion.identity);
		}
		this.gameObject.GetComponent<BoxCollider2D>().enabled = false;


	}
}
