﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayButtonClicks()
    {
        UIController.instance.isPause = false;
        UIController.instance.ShowGameplay();
    }
}
