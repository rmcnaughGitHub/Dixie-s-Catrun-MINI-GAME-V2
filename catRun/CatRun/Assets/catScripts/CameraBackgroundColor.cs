using UnityEngine;
using System.Collections;

public class CameraBackgroundColor : MonoBehaviour {

	//http://docs.unity3d.com/ScriptReference/Camera-backgroundColor.html

	//Colors
	public Color color1 = Color.red;//Color(240,208,80);
	public Color color2 = Color.blue;//Color(51,235,238);
	public float duration = 3.0f;

	// Use this for initialization
	void Start () {
		//Camera color control
		//camera = GetComponent<Camera>();
		//camera.clearFlags = CameraClearFlags.Color;
	}
	
	// Update is called once per frame
	void Update () {
		//change clor gradually
		//float t = Mathf.PingPong(Time.time, duration)/duration;
		//camera.backgroundColor = Color.Lerp (color1, color2);
	}
}
