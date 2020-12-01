using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGV76 : MonoBehaviour
{//모노클끼면 태권브이 이미지 보이게 하느거 추가
    public BoxCollider2D boxcol;
    public GameObject gameobj;
    public BoxCollider2D[] TGV;
    public GameObject[] TGV_UI;
    public GameObject[] TGV_VSXZ;



    void Start()
    {

        TGV_TGV_UI_bool(false);
        TGV_TGV_VSXZ_bool(false);
        TGV_TGV_bool(true);
        gameobj.SetActive(false);
    }

    void Update()
    {
        if (!GameManager.Instance.startMission)// 미션중이 아닐 때
        {
            if (GameManager.Instance.missionCount != 0) //클리어 판정이 나면...
            {
                boxcol.enabled = false;
                TGV_UI[6].SetActive(false);
                GameManager.Instance.startMission = false;
                TGV_TGV_UI_bool(false);
                TGV_TGV_VSXZ_bool(false);
            }
            if (GameManager.Instance.missionCount == 0) //클리어 판정이 안나고 초기화하면.
            {
                boxcol.enabled = false;
                TGV_UI[6].SetActive(false);
                GameManager.Instance.startMission = false;
                TGV_TGV_UI_bool(false);
                TGV_TGV_VSXZ_bool(false);
                gameobj.SetActive(false);

                TGV_TGV_bool(true);
            }
        }

        Debug.Log(GameManager.Instance.missionCount);

        if (GameManager.Instance.isMonocle)
        {
            if (GameManager.Instance.missionCount == 0)
            {
                boxcol.enabled = true;
                gameobj.SetActive(true);
            }
        }
        else
        {
            gameobj.SetActive(false);
        }

        if (GameManager.Instance.missionCount == 0 && GameManager.Instance.startMission)
        {
            PuZ();
            TGV_UI[6].SetActive(true);
        }
    }

    void PuZ()
    {
        if (GameManager.Instance.isClick == true)
        {
            if (Click.ReturnName() == "TGV_Hd")
            {
                getfalse(0); //머리를 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Bd")
            {
                getfalse(1); // 몸을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_La")
            {
                getfalse(2); // 왼팔을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Ra")
            {
                getfalse(3); // 오른팔을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Li")
            {
                getfalse(4); // 왼다리를 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Ri")
            {
                getfalse(5); // 오른다리를 클릭했다.
            }

            if (!TGV[0].enabled && !TGV[1].enabled && !TGV[2].enabled && !TGV[3].enabled && !TGV[4].enabled && !TGV[5].enabled) //6개를 다 모으면 뭐.. 이미지 등장
            {
                TGV_TGV_VSXZ_bool(true);


            }
        }
    }

    void getfalse(int getObj)
    {
        TGV[getObj].enabled = false; //배치 obj col은 비활하고
        TGV_UI[getObj].SetActive(true); //ui sprite는 활성
        Debug.Log(Click.ReturnName()+"d");
    }

    //뭔가 3개를 하나로 만들 수 있을 것 같은데...
    void TGV_TGV_bool(bool mission)
    {
        for (int i = 0; i < TGV.Length; i++)
        {
            TGV[i].enabled = mission;
        }
    }

    void TGV_TGV_UI_bool(bool mission)
    {
        for (int i = 0; i < TGV_UI.Length; i++)
        {
            TGV_UI[i].SetActive(mission);
        }
    }

    void TGV_TGV_VSXZ_bool(bool mission)
    {
        for (int i = 0; i < TGV_VSXZ.Length; i++)
        {
            TGV_VSXZ[i].SetActive(mission);
        }
    }
}
