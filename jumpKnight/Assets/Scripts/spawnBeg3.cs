using UnityEngine;
using System.Collections;

public class spawnBeg3 : MonoBehaviour {

	public float x, y;
	public GameObject level, destroyer;
	private bool stop = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (stop == false) {
						if (other.tag == "Player") {

								Instantiate (level, new Vector3 (x, y, 0f), Quaternion.identity);
				Destroy(GameObject.Find("QuadSide"));
								stop = true;
								this.gameObject.GetComponent<Collider2D> ().enabled = false;

						}
				}


	}
}
