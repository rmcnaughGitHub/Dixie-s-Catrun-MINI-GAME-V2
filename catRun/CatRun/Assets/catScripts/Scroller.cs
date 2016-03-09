﻿using UnityEngine;
using System.Collections;

public class Scroller : MonoBehaviour {
	
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 offset = new Vector2 (Time.time * speed, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;
		//https://www.youtube.com/watch?v=HrDxnMI7pCc
	}
}
