using UnityEngine;
using System.Collections;

public class upAndDownScript : MonoBehaviour {

	public Vector3 pointB;
	public float speed;

	IEnumerator Start()
	{
		var pointA = transform.position;
		while (true) {
			Vector3 theScale = transform.localScale;
			theScale.y *= -1.0f;
			transform.localScale = theScale;
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, speed));
			Vector3 theScale1 = transform.localScale;
			theScale1.y *= -1.0f;
			transform.localScale = theScale1;
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, speed));
		}
	}
	
	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		var i= 0.0f;
		var rate= 1.0f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			
			yield return null; 
		}
	}
	
	
	
	
}
