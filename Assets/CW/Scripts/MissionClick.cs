using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionClick : MonoBehaviour
{
    public GameObject []mcImg;
    public int myStage;

    void Start()
    {
        for(int i = 0; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(false);
        }
    }

    void Update()
    {
        if (GameManager.Instance.isClick && GameManager.Instance.isMonocle && myStage == GameManager.Instance.missionCount)
        {
            missionImg();
        }
    }
 

    void missionImg()
    {
        for(int i = 2; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(true);
        }
    }
}
