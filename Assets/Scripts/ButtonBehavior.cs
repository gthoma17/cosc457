﻿using UnityEngine;
using System.Collections;

public class ButtonBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartNextLevel(string levelName){
		Application.LoadLevel(levelName);
	}
}
