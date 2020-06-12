using UnityEngine;
using System.Collections;

public class pathProjectileSpawner : MonoBehaviour {
	
	public Transform destination;
	public pathedProjectile proj1;
	public pathedProjectile proj2;
	
	public float speed;
	public float fireRate;
	public int n;
	
	private float nextShotInSeconds;
	
	// Use this for initialization
	void Start () {
		
		nextShotInSeconds = fireRate;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((nextShotInSeconds -= Time.deltaTime) > 0)
			return;
		
		nextShotInSeconds = fireRate;
		n = Random.Range (0, 10);
		Debug.Log(n);
		if (n == 2) {
			var _projectile1 = (pathedProjectile)Instantiate (proj1, transform.position, transform.rotation);
			_projectile1.Initialize (destination, speed);
		}
		if (n == 3) {
			var _projectile2 = (pathedProjectile)Instantiate (proj2, transform.position, transform.rotation);
			_projectile2.Initialize (destination, speed);
		}
		
		//_projectile.Initialize (destination, speed);
		
	}
	
	
}