﻿using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown)
        {
            Application.LoadLevel("main-menu");
        }
	}
    //private void KeyPressedEventHandler() { Application.LoadLevel("main-menu"); }
}
