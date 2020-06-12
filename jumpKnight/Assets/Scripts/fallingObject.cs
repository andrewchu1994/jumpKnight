using UnityEngine;
using System.Collections;

public class fallingObject : MonoBehaviour {

	public GameObject projectile;
	public float speedFactor;
	public float min,max;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (Shoots());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	IEnumerator Shoots(){
		
		while (true) {
			
			yield return new WaitForSeconds(Random.Range(min,max));
			
			GameObject clone = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
			
			clone.GetComponent<Rigidbody2D>().velocity = -transform.up * speedFactor;

			
		}
		
	}
}
