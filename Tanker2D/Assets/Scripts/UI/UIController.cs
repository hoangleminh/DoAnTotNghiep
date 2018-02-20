using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public static UIController _instance;
    public static UIController instance
    {
        get
        {
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
        }
        _instance = this;
    }

    public StartUI startUI;
    public PauseUI pauseUI;
    public GameoverUI gameoverUI;
    public Button PauseButton;
    public bool isPause;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowStartUI()
    {
        startUI.gameObject.SetActive(true);
        pauseUI.gameObject.SetActive(false);
        gameoverUI.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(false);
    }

    public void ShowPauseUI()
    {
        startUI.gameObject.SetActive(false);
        pauseUI.gameObject.SetActive(true);
        gameoverUI.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(false);
    }

    public void ShowGameoverUI()
    {
        startUI.gameObject.SetActive(false);
        pauseUI.gameObject.SetActive(false);
        gameoverUI.gameObject.SetActive(true);
        PauseButton.gameObject.SetActive(false);
    }

    public void ShowGameplay()
    {
        startUI.gameObject.SetActive(false);
        pauseUI.gameObject.SetActive(false);
        gameoverUI.gameObject.SetActive(false);
        PauseButton.gameObject.SetActive(true);
    }
}
