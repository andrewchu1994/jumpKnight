using UnityEngine;
using System.Collections;

public class completedLevel13 : MonoBehaviour {
	
	public int ppInt; 
	public GameObject golden;
	public float x,y,z;
	private bool stopper = true;
	private SpriteRenderer sprite_renderer;
	
	// Use this for initialization
	void Start () {
		ppInt = PlayerPrefs.GetInt("test2"); 
		sprite_renderer = GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (ppInt == 2 && stopper == true) {
			
			Instantiate(golden, new Vector3(x,y,z), Quaternion.identity);
			
			sprite_renderer.enabled = false;
			stopper = false;
			
		}
		
		
		
	}
}
