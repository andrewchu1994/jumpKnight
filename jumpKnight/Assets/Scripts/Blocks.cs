using UnityEngine;
using System.Collections;

public class Blocks : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D block) {

		if (block.tag == "rainDrop") {
			block.gameObject.GetComponent<BoxCollider2D>().enabled = false;
				}

		else if (block.gameObject.transform.parent) {

						Destroy (block.gameObject.transform.parent.gameObject);
				} 

		else
						Destroy (block.gameObject);
	
	}
	

}
