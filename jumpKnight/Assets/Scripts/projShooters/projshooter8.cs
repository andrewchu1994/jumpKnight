using UnityEngine;
using System.Collections;

public class projshooter8 : MonoBehaviour
	
	
{
	
	public GameObject projectile;
	public float speedFactor;
	public float delay;
	//private bool stop2 = false;
	
	
	// Use this for initialization
	void Start ()
	{
		Shoots(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	//	IEnumerator Shoots(){
	//		
	//		if (stop == true) {
	//
	//			yield return new WaitForSeconds(delay);
	//			
	//			GameObject clone = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);
	//			
	//			clone.rigidbody2D.velocity = -transform.right * speedFactor;
	//
	//			stop = false;
	//			
	//			
	//		}
	//		
	//	}
	
	public void Shoots(bool stop2){
		
		if (stop2 == true) {
			
			GameObject clone = (GameObject)Instantiate (projectile, transform.position, Quaternion.identity);
			
			clone.GetComponent<Rigidbody2D>().velocity = -transform.right * speedFactor;
			
			stop2 = false;
			
		}
		
		
	}
}

