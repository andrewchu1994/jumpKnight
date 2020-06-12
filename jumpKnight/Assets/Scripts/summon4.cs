using UnityEngine;
using System.Collections;

public class summon4 : MonoBehaviour {
	
	public GameObject obj, obj2, obj3;
	private bool stop = false;
	//private projShooter shooter;
	//private projShooter2 shooter2;
	//private projShooter3 shooter3;
	//private projshooter4 shooter4;
	//private projshooter5 shooter5;
	//private projShooter6 shooter6;
	//private projShooter7 shooter7;
	//private projshooter8 shooter8;
		private projShooter9 shooter9;
		private projShooter10 shooter10;
	private projShooter11 shooter11;
	
	// Use this for initialization
	void Start () {
		
		shooter9 = FindObjectOfType<projShooter9> ();
		shooter10 = FindObjectOfType<projShooter10> ();
		shooter11 = FindObjectOfType<projShooter11> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (stop == false) {
			if (other.tag == "Player") {
				
				Instantiate (obj, new Vector3(shooter9.transform.position.x,shooter9.transform.position.y,0), Quaternion.identity);
				Instantiate (obj2, new Vector3(shooter10.transform.position.x,shooter10.transform.position.y,0), Quaternion.identity);
				Instantiate (obj3, new Vector3(shooter11.transform.position.x,shooter11.transform.position.y,0), Quaternion.identity);
				//Instantiate (obj3, new Vector3(shooter3.transform.position.x,shooter3.transform.position.y,0), Quaternion.identity);
				//Instantiate (obj4, new Vector3(shooter4.transform.position.x,shooter4.transform.position.y,0), Quaternion.identity);
				shooter9.Shoots(true);
				shooter10.Shoots(true);
				shooter11.Shoots(true);
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
