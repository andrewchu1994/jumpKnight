using UnityEngine;
using System.Collections;

public class pathedProjectile : MonoBehaviour {

	private Transform _destination;
	private float _speed;

	public void Initialize(Transform destination , float speed){

		_destination = destination;
		_speed = speed;

	}

	public void Update(){

		transform.position = Vector3.MoveTowards (transform.position, _destination.position, Time.deltaTime * _speed);

		var distanceSquared = (_destination.transform.position - transform.position).sqrMagnitude;
		if (distanceSquared > .01f * .01f)
						return;

		Destroy (gameObject);

	}
}
