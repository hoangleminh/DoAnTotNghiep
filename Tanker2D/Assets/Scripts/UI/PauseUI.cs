using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonPauseClicks()
    {
        if (UIController.instance.isPause == false)
        {
            UIController.instance.isPause = true;
            UIController.instance.ShowPauseUI();
        }
    }

    public void ButtonReplayClicks()
    {
        UIController.instance.isPause = false;
        UIController.instance.ShowGameplay();
    }

    public void ButtonQuitClicks()
    {
        UIController.instance.isPause = true;
        UIController.instance.ShowStartUI();
    }
}
