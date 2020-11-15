using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public GameObject []mcImg;
    

    void Start()
    {
        for (int i = 0; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(false);
        }
    }

    void Update()
    {
        if (GameManager.Instance.isClick && Click.ReturnTag() == "MonocleObj")
        {
            GameManager.Instance.startMission = false;
            missionImg();
        }
    }
 

    void missionImg()
    {
        GameManager.Instance.missioning = true;

        for (int i = 0; i < 2; i++)
        {
            mcImg[i].SetActive(true);
        }
        mcImg[GameManager.Instance.missionCount+2].SetActive(true);

        
        Debug.Log(GameManager.Instance.missionCount);
    }

    public void missionImgOff()
    {
        GameManager.Instance.missioning = false;

        for (int i = 0; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(false);
        }

        GameManager.Instance.startMission = true;
    }
}
