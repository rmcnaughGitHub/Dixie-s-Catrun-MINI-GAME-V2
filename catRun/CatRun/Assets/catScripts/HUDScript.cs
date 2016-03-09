using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	//GUI
	//https://www.youtube.com/watch?v=7dP7R-GbFkM&list=PL70sYxF2_NMWHvpdhoblKdWBduUyhqPPi&index=9

	//Import Fonts
	//http://instantiateunity.blogspot.com/2012/05/how-to-import-and-use-fonts.html

	float PlayerScore = 0;
	public GUIStyle style = null;//adds style properties
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PlayerScore += Time.deltaTime;//score contiously increases
	}

	//For PowerUps
	public void IncreaseScore(int amount){
		PlayerScore += amount;
	}


	//Pass score to player prefs on the next scene
	void onDisable(){
		PlayerPrefs.SetInt("Score", (int)PlayerScore);
	}

	//SHOW SCORE
	void OnGUI(){
		GUI.contentColor = Color.black;//text color black
		GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(PlayerScore * 100), style);
		//Screen.Width or Screen.Height for position alternative
	}
	
}
