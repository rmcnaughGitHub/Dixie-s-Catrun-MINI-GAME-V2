using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public Texture2D start;//get texture for button

	// Use this for initialization
	void Start () {
		//load texture
		start = (Texture2D)Resources.Load("start");
		Debug.Log("Button Image " +start);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		//Create button - apply button texture, position it, declare button image, remove button style
		if (GUI.Button (new Rect (Screen.width / 2 - (start.width/2+20), 350, 121, 61), start, GUIStyle.none)) {
			Application.LoadLevel(1);
		}
	}
}
