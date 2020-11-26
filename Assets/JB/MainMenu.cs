using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject help2;
 

    public void OnClickStart()
    {
        SceneManager.LoadScene("MainScene");
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
