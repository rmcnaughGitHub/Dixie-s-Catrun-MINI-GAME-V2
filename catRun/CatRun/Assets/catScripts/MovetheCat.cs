using UnityEngine;
using System.Collections;

public class MovetheCat : MonoBehaviour {

	//Speed
	public float speed = 0.5f;

	//Move Player
	public bool Run = false;
	public bool _accelGradually = false;
	public float _accelSpeed = 0.05f;//increase speed graudally over time

	//Controls Jump
	//https://www.youtube.com/watch?v=2akPDnmSfu8 && https://www.youtube.com/watch?v=1rbi347F4u0
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	private bool doubleJump;
	public float jumpHeight;
	
	//Use this for initialization
	void Start () {

	}

	//Called set amount of times
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		GetComponent<Animator>().SetBool("Grounded", grounded);//Set Animation status //http://www.raywenderlich.com/69544/make-game-like-jetpack-joyride-unity-2d-part-2
	}


	//Update is called once per frame
	void Update () {
		//Speed up gradually
		if(_accelGradually == true){
			speed += _accelSpeed;
		}
		//Move the Player
		if (Run == true) {
			transform.Translate (speed * Time.deltaTime, 0f, 0f);
		}
		//Jump
		if (grounded) {
			doubleJump = false;
		}
		if(Input.GetKeyDown(KeyCode.UpArrow) && grounded) {
			Jump();
		}
		if(Input.GetKeyDown(KeyCode.UpArrow) && !doubleJump && !grounded) {
			Jump();
			doubleJump = true;
		}
	}

	//JUMP 
	void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
	}
}
