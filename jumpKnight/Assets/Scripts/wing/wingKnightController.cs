using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using GoogleMobileAds.Api;

public class wingKnightController : MonoBehaviour {
	
	public float maxSpeed = 10f;
	bool facingRight = true;
	
	public Animator anim;
	public bool isDead;
	public bool grounded;
	public Transform groundCheck;
	public float groundRadius;
	public LayerMask whatIsGround;
	public float jumpForce;
	public GameObject jumpKey;
	public float move;
	public Rigidbody2D myrigidbody2d;
	//public BannerView bannerView2;

	public bool doubleJump;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();
		myrigidbody2d = GetComponent<Rigidbody2D> ();

		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//		if (isDead == true) {
		//#if UNITY_WEBPLAYER || UNITY_STANDALONE
		//			if(Input.GetKeyDown(KeyCode.R)){
		//				Application.LoadLevel(Application.loadedLevel);
		//			}
		//#endif
		//
		//			return;
		//		}
	

	//	StartCoroutine ("waiting");
		
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		
	}
	
	public void Update(){

		if (grounded)
						doubleJump = false;
		
		if (isDead == true) {
			#if UNITY_WEBPLAYER || UNITY_STANDALONE
			if (Input.GetKeyDown (KeyCode.R)) {
				
				Application.LoadLevel (Application.loadedLevel);
				
				//				isDead = false;
				//				this.transform.position = spawn.transform.position;
				//				anim.SetBool("dies", false);
				//				myrigidbody2d.isKinematic = false;
				
				
			}
			#endif
			
			return;
		}
		
		//android back button
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Time.timeScale = 1;
			Application.LoadLevel("lvl2SelectionScreen");
	}

		
		anim.SetBool ("ground", grounded);
		anim.SetFloat ("vspeed", myrigidbody2d.velocity.y);
		anim.SetFloat ("speed", Mathf.Abs (move));
		
		
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
		
		
		//i should fix this..
		myrigidbody2d.velocity = new Vector2 (move, myrigidbody2d.velocity.y);
		
		moving (Input.GetAxisRaw ("Horizontal"));
		
		
		
		
		#if UNITY_WEBPLAYER || UNITY_STANDALONE
		
		if (grounded && Input.GetButtonDown("Jump") && !isDead) {
			jumping ();
			
		}
		#endif

		#if UNITY_WEBPLAYER || UNITY_STANDALONE
		
		if (!doubleJump && !grounded && Input.GetButtonDown ("Jump") && !isDead) {
			jumping ();
			doubleJump = true;

			
		}
		#endif

	}
	
	public void jumping(){
		if (!isDead) {
			myrigidbody2d.velocity = new Vector2(myrigidbody2d.velocity.x, jumpForce);
		}

		
	}
	
	public void moving(float moveInput){
		
		move = maxSpeed * moveInput;
	}
	

	
	public void OnTriggerEnter2D(Collider2D other){
		
		if ((other.tag == "danger" && !isDead) || (other.tag == "rainDrop" && !isDead)) {
			
						myrigidbody2d.velocity = Vector2.zero;
						myrigidbody2d.isKinematic = true;
						anim.SetTrigger ("explode");
						gameObject.GetComponent<AudioSource>().Play();
						other.gameObject.GetComponent<Collider2D> ().enabled = false;
						anim.SetBool ("dies", true);
						anim.SetBool ("ground", true);
						isDead = true;
					//	RequestBanner2();

						//			attempts += 1;
						//			attemptsCounter.text = "Attempts: " + attempts.ToString();
			
			
				} else if (other.tag == "portal") {
			
						myrigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
			
				} 
	}

	
//	IEnumerator waiting(){
//		
//		if (isDead == true) {
//			yield return new WaitForSeconds (1f);
//			Application.LoadLevel (Application.loadedLevel);
//		}
//		
//	}
	
	
	void Flip(){
		
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		
	}

	/* public void RequestBanner2()
	{
		#if UNITY_ANDROID
		string adUnitId = "ca-app-pub-8349473488660142/1480634111";
		#elif UNITY_IPHONE
		string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
		#else
		string adUnitId = "unexpected_platform";
		#endif

	*/
		
		// Create a 320x50 banner at the top of the screen.
	//	bannerView2 = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
	//	AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
	//	bannerView2.LoadAd (request);
		
		
		
		
	}
	
//}
