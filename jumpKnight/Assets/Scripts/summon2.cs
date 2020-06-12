using UnityEngine;
using System.Collections;

public class summon2 : MonoBehaviour {
	
	public GameObject obj, obj2;
	private bool stop = false;
	//private projShooter shooter;
	//private projShooter2 shooter2;
	//private projShooter3 shooter3;
	private projshooter4 shooter4;
		private projshooter5 shooter5;
	//	private projShooter2 shooter6;
	//	private projShooter2 shooter7;
	//	private projShooter2 shooter8;
	//	private projShooter2 shooter9;
	//	private projShooter2 shooter10;
	
	// Use this for initialization
	void Start () {
		
		shooter4 = FindObjectOfType<projshooter4> ();
		shooter5 = FindObjectOfType<projshooter5> ();
		//shooter3 = FindObjectOfType<projShooter3> ();
		//shooter4 = FindObjectOfType<projshooter4> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (stop == false) {
			if (other.tag == "Player") {
				
				Instantiate (obj, new Vector3(shooter4.transform.position.x,shooter5.transform.position.y,0), Quaternion.identity);
				Instantiate (obj2, new Vector3(shooter5.transform.position.x,shooter5.transform.position.y,0), Quaternion.identity);
				//Instantiate (obj3, new Vector3(shooter3.transform.position.x,shooter3.transform.position.y,0), Quaternion.identity);
				//Instantiate (obj4, new Vector3(shooter4.transform.position.x,shooter4.transform.position.y,0), Quaternion.identity);
				shooter4.Shoots(true);
				shooter5.Shoots(true);
				//shooter3.Shoots(true);
				//shooter4.Shoots(true);
				//				shooter5.Shoots(true);
				//				shooter6.Shoots(true);
				//				shooter7.Shoots(true);
				//				shooter8.Shoots(true);
				//				shooter9.Shoots(true);
				//				shooter10.Shoots(true);
				stop = true;
				this.gameObject.GetComponent<Collider2D>().enabled = false;
				
			}
			
		}
	}
}
