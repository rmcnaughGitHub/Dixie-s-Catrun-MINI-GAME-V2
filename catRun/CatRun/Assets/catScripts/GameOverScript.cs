using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;//score
	public Texture2D retry;//get texture for button
	public GUIStyle style = null;//text color
	
	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("Score");//get score from last scene
		//load texture
		retry = (Texture2D)Resources.Load("retry");
		//Debug.Log("Button Image " +retry);
	}
	
	// Update is called once per frame
	void Update () {
	}

	//game over label
	void OnGUI(){
		/*/GUI.contentColor = Color.red;
		GUI.Label (new Rect(Screen.width /2 -40, 300, 80, 30), "Score: " + score, style);//show score*/

		//gui button created to restart level
		/*if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 60, 30), "Retry?")) {
			Application.LoadLevel(0);
		}*/

		//Create button - apply button texture, position it, declare button image, remove button style
		if (GUI.Button (new Rect (Screen.width / 2 - (retry.width/2+20), 350, 121, 61), retry, GUIStyle.none)) {
			Application.LoadLevel(1);
		}

	}
}
