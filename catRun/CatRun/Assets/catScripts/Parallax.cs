using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {

	public Vector2 speed = new Vector2(2, 2);
	public Vector2 direction = new Vector2(-1, 0);

	public float distanceToRespawn = 0f;
	public bool isLinkedToCamera = false;
	public bool isLooping = false;

	//Change Alpha
	public GameObject Sprite;
	public float Alpha = 1f;

	//bumperleft gameobject to check position torespawn
	public GameObject BumperLeft;

	// Use this for initialization
	void Start () {
		//Sprite.GetComponent<Renderer>().material.color.a = new Color(Alpha,Alpha,Alpha);
		BumperLeft = GameObject.Find ("BumperLeft");//get left bumper
	}
	
	// Update is called once per frame
	void Update () {
		//move
		Vector3 movement = new Vector3 (
			speed.x * direction.x,
			speed.y * direction.y,
		0);

		movement *= Time.deltaTime;
		transform.Translate(movement);

		//move with camera if needed
		if (isLinkedToCamera) {
			Camera.main.transform.Translate(movement);
		}

		//if looping
		if (isLooping) {
			if (transform.position.x < -17){//Camera.main.transform.position.x 
				transform.position = new Vector3(distanceToRespawn, transform.position.y, transform.position.z);
				//Debug.Log("PAST BOUNDS");
			}
			if( transform.position.x <  BumperLeft.transform.position.x){
				//Debug.Log("COLLIDE");
				transform.position = new Vector3(distanceToRespawn + (Camera.main.transform.position.x), transform.position.y, transform.position.z);
			}
		}
	}


}
