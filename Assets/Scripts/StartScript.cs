﻿using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.Space)){
			transform.Rotate(-90f,0f,0f);
		}
	}
}
