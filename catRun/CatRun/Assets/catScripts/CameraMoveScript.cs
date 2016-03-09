using UnityEngine;
using System.Collections;

public class CameraMoveScript : MonoBehaviour {


	public Transform player;
	
	// Update is called once per frame
	void Update () {
		try {
			transform.position = new Vector3 (player.position.x + 6, 0, -10);
		}
		catch{

		}
	}
}
