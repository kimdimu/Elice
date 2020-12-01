using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCup : MonoBehaviour
{
    public GameObject Devil1;
    public GameObject Devil2;
    public GameObject Devil3;
    public GameObject Devil4;
    public GameObject RedDevil;

    public GameObject ball;
    public BoxCollider2D ballCol;
    public GameObject devil;
    public BoxCollider2D devilCol;

    public static WorldCup WB;
    public bool WC = false;

    void Start()
    {
        WB = this;
        devil.SetActive(false);
        devilCol.enabled = false;
        ballCol.enabled = false;
    }


    void Update()
    {
        if(!GameManager.Instance.startMission && GameManager.Instance.missionCount == 8)
        {
            Devil1.gameObject.SetActive(true);
            Devil2.gameObject.SetActive(false);
            Devil3.gameObject.SetActive(false);
            Devil4.gameObject.SetActive(false);
            RedDevil.gameObject.SetActive(false);
        }

        //if (GameManager.Instance.isClick && Click.ReturnName() == "BallCol" && GameManager.Instance.missionCount == 6)
        if(GameManager.Instance.missionCount == 6)
        {
            if (WB.WC == true)
            {
                //성공
                GameManager.Instance.clear = true;
            }
            else
            {
                //실패
                //Debug.Log("fail");
                //GameManager.Instance.startMission = false;
            }
        }


        if (GameManager.Instance.missionCount == 6 && GameManager.Instance.isMonocle) // + 모노클 상태면
        {
            Debug.Log("6_monocle");
            ball.SetActive(true);
            devilCol.enabled = true;
            ballCol.enabled = false;
        }
        else
        {
            ball.SetActive(false);
        }

        if (GameManager.Instance.missionCount == 6 && GameManager.Instance.startMission) // 6번 미션 중일 때
        {
            if(!GameManager.Instance.isMonocle)
            ballCol.enabled = true;

            devil.SetActive(true);
            devilCol.enabled = false;

            DollChange();
        }
    }

    void DollChange()
    {
        if (GameManager.Instance.isClick && Click.ReturnTag() == "RedDevilDoll")
        {
            int ran = Random.Range(0, 6);
            //Random.Range(0, 6);

            if (ran == 1)           //붉은악마는 1번
            {
                Devil1.gameObject.SetActive(false);
                Devil2.gameObject.SetActive(false);
                Devil3.gameObject.SetActive(false);
                Devil4.gameObject.SetActive(false);
                RedDevil.gameObject.SetActive(true);

                WC = true;
            }
            else if (ran == 2)
            {
                Devil1.gameObject.SetActive(true);
                Devil2.gameObject.SetActive(false);
                Devil3.gameObject.SetActive(false);
                Devil4.gameObject.SetActive(false);
                RedDevil.gameObject.SetActive(false);

                WC = false;
            }
            else if (ran == 3)
            {
                Devil1.gameObject.SetActive(false);
                Devil2.gameObject.SetActive(true);
                Devil3.gameObject.SetActive(false);
                Devil4.gameObject.SetActive(false);
                RedDevil.gameObject.SetActive(false);

                WC = false;
            }
            else if (ran == 4)
            {
                Devil1.gameObject.SetActive(false);
                Devil2.gameObject.SetActive(false);
                Devil3.gameObject.SetActive(true);
                Devil4.gameObject.SetActive(false);
                RedDevil.gameObject.SetActive(false);

                WC = false;
            }
            else if (ran == 5)
            {
                Devil1.gameObject.SetActive(false);
                Devil2.gameObject.SetActive(false);
                Devil3.gameObject.SetActive(false);
                Devil4.gameObject.SetActive(true);
                RedDevil.gameObject.SetActive(false);

                WC = false;
            }

        }
    }

}
