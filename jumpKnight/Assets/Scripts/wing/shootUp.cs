using UnityEngine;
using System.Collections;

public class shootUp : MonoBehaviour {
	
	public GameObject projectile;
	public float speedFactor;
	public float min,max;
	public Animator anim;
	
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		StartCoroutine (Shoots());
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	IEnumerator Shoots(){
		
		while (true) {

			yield return new WaitForSeconds(Random.Range(min,max));

			anim.SetTrigger("budShoot2");
			GameObject clone = (GameObject)Instantiate(projectile, transform.position, Quaternion.identity);

			
			clone.GetComponent<Rigidbody2D>().velocity = transform.up * speedFactor;


			
			
		}
		
	}
}
