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
    public GameUI gameUI;
    public GameoverUI gameoverUI;
    public bool isPause;

    // Use this for initialization
    void Start()
    {
        ShowStartUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowStartUI()
    {
        startUI.gameObject.SetActive(true);
        gameUI.gameObject.SetActive(false);
        gameoverUI.gameObject.SetActive(false);
    }

    public void ShowGameUI()
    {
        startUI.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(true);
        gameoverUI.gameObject.SetActive(false);
    }

    public void ShowGameoverUI()
    {
        startUI.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(false);
        gameoverUI.gameObject.SetActive(true);
    }
}
