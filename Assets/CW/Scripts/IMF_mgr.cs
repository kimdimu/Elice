using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMF_mgr : MonoBehaviour
{
    public GameObject toEnd;
    public BoxCollider2D monoCol;
    public GameObject monoObj;
    public GameObject[] flies;
    public int[] boolflies;

    public GameObject[] redImg;


    int goidCount;
    int num;
    
    void Start()
    {
        redImg[0].SetActive(false);
        redImg[1].SetActive(false);
        boolflies = new int[6];
        toEnd.SetActive(false);
        num = 0;
        goidCount = 0;
        monoObj.SetActive(false);
        monoCol.enabled = false;
        for (int i = 0; i < flies.Length; i++)
        {
            flies[i].SetActive(false);
        }
        for (int i = 0; i < boolflies.Length; i++)
        {
            boolflies[i] = 0;
        }
    }



void Update()
    {
        if (!GameManager.Instance.startMission)//미션중이 아니다. 미션이 끝났다. 초기화하자
        {
            toEnd.SetActive(false);
            num = 0;
            for (int i = 0; i < flies.Length; i++) //파리들을 끈다.
            {
                flies[i].SetActive(false);
            }
            for (int i = 0; i < boolflies.Length; i++)
            {
                boolflies[i] = 0;
            }

            monoObj.SetActive(false);
        }

        if (GameManager.Instance.isMonocle) //모노클 O
        {
            redImg[0].SetActive(false);
            redImg[1].SetActive(false);
            if (GameManager.Instance.missionCount == 3)
            {
                toEnd.SetActive(false);
                monoCol.enabled = true;
                monoObj.SetActive(true);

                for (int i = 0; i < flies.Length; i++) //파리들을 끈다.
                {
                    flies[i].SetActive(false);
                }
            }
        }
        else // 모노클 껐을 때
        {
            monoObj.SetActive(false);
        }

        if (GameManager.Instance.missionCount == 3 && GameManager.Instance.startMission) // 3번 미션이 진행중이면
        {
            if(!GameManager.Instance.isMonocle)
                toEnd.SetActive(true); //테이블 콜라이더 온

            for (int i = 0; i < flies.Length; i++) //파리들을 켠다.
            {
                if (num <= flies.Length)
                {
                    flies[i].SetActive(true);
                    num++;
                }
            }

            if (GameManager.Instance.isClick == true)
            {
                if (Click.ReturnName() == "금괴") //클릭한 놈이 금괴면...
                {
                    getfalse(0);
                }
                if (Click.ReturnName() == "금니")  // . . . / /
                {
                    getfalse(1);
                }
                if (Click.ReturnName() == "금반지")
                {
                    getfalse(2);
                }
                if (Click.ReturnName() == "은괴")
                {
                    getfalse(3);
                }
                if (Click.ReturnName() == "은반지")
                {
                    getfalse(4);
                }
                if (Click.ReturnName() == "다이아")
                {
                    getfalse(5);
                }
            }

            if (GameManager.Instance.isClick && Click.ReturnName() == "IMF_magagine") // 저놈을 클릭하면
            {
                Debug.Log("click magagine");
                if (boolflies[0] == 1 && boolflies[1] == 1 && boolflies[2] == 1 && boolflies[3] == 0 && boolflies[4] == 0 && boolflies[5] == 0)
                {
                    GameManager.Instance.clear = true;
                }
                else
                {
                    GameManager.Instance.startMission = false;
                    redImg[0].SetActive(true);
                    redImg[1].SetActive(true);
                    MissionManager.missionfailsound();
                }
            }
        }

        void getfalse(int getObj)
        {
            flies[getObj].SetActive(false); //배치 obj col은 비활하고
            Debug.Log(Click.ReturnName());
            boolflies[getObj] = 1;
            GetSound.instance.playSound();

        }
    }
}
