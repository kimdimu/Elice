using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{

    void Update()
    {
        if(GameManager.Instance.missionCount == 8)
        {
            SceneManager.LoadScene("EndingScene");
        }
    }
}
