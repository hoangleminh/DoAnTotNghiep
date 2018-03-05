using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

    public Button pausebutton;
    public Button resumebutton;
	// Use this for initialization
	void Start () {
        pausebutton.gameObject.SetActive(true);
        resumebutton.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnButtonPauseClicks()
    {
        pausebutton.gameObject.SetActive(false);
        Time.timeScale = 0;
        resumebutton.gameObject.SetActive(true);
    }

    public void OnButtonResumeClicks()
    {
        resumebutton.gameObject.SetActive(false);
        Time.timeScale = 1;
        pausebutton.gameObject.SetActive(true);
    }
}
