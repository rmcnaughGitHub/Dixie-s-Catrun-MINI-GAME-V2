using UnityEngine;
using System.Collections;

public class DuplicateMove : MonoBehaviour {
	
	public float speed = 1f;
	public float vel = 0.05f;
	public float _accel = 0.095f;
	public int spriteNum = 5;
	private float index;
	private float yPos;
	
	public GameObject obj;

	// Use this for initialization
	void Start () {
		duplicate();
		print(gameObject.name);//get the name of the gameObject
	}
	
	// Update is called once per frame
	void Update () {
		index += Time.deltaTime;
		yPos = Mathf.Abs( (_accel * speed)  * Mathf.Sin(vel* index));//up and down motion
		//
		try 
		{
			transform.position = new Vector2(transform.position.x, yPos);
			//Debug.Log("yPos " +yPos);
		}
		catch{
			Debug.Log("Error " +yPos);
		}
	}

	void duplicate(){
		Instantiate( obj, transform.position, Quaternion.identity);
		Invoke("Spawn",1);//Random.Range (speed, spriteNum));
	}
}