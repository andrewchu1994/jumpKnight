using UnityEngine;
using System.Collections;

public class pathShooter : MonoBehaviour {
	
	public Transform destination;
	public pathedProjectile proj1;
	private Animator anim;

	
	public float speed;
	public float fireRate;
																						
	private float nextShotInSeconds;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		nextShotInSeconds = fireRate;
		
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if ((nextShotInSeconds -= Time.deltaTime) > 0)
			return;
		anim.SetTrigger ("budShoot2");
		nextShotInSeconds = fireRate;


			var _projectile1 = (pathedProjectile)Instantiate (proj1, transform.position, transform.rotation);
	
			_projectile1.Initialize (destination, speed);
	
	
		
		//_projectile.Initialize (destination, speed);
		
	}
	
	
}