using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	//https://www.youtube.com/watch?t=3296&v=7dP7R-GbFkM

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			Application.LoadLevel(2);//load next level
			//Debug.Break();//Stop Game
			return;
		}

		if (other.gameObject.transform.parent) {
			//find game object destroy if has a parent
			Destroy (other.gameObject.transform.parent.gameObject);
		} else {
			Destroy (other.gameObject);
		}

		//Recycle Parallax Elements
		/*if (other.tag == "Parallax") {

		}*/
	}

}
