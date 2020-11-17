﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mainmenu;
    public GameObject help2;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("FusionScene");
        Debug.Log("시작");
    }
    public void OnClickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void OnClickHelp()
    {

        help2.SetActive(true);
        mainmenu.SetActive(false);
        Debug.Log("도움말");
    }

    public void OnClickeHelpBack()
    {
        help2.SetActive(false);
        mainmenu.SetActive(true);
    }

    public void OnClickSet()
    {
        Debug.Log("설정");
    }
}