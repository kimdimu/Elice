using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGV76 : MonoBehaviour
{
    public BoxCollider2D boxcol;
    public BoxCollider2D[] TGV;
    public GameObject[] TGV_UI;
    public GameObject[] TGV_VSXZ;

    int pieceCount = 0;

    void Start()
    {
        TGV_TGV_UI_bool(false);
        TGV_TGV_VSXZ_bool(true);
        TGV_TGV_bool(true);
    }

    void Update()
    {
        if (!GameManager.Instance.startMission)// 미션중이 아닐 때 초기화
        {
            if (GameManager.Instance.missionCount != 0) //클리어 판정이 나면...
            {
                pieceCount = 0;
                boxcol.enabled = false;
                TGV_UI[6].SetActive(false);
                GameManager.Instance.startMission = false;
                TGV_TGV_UI_bool(false);
            }
            if (GameManager.Instance.missionCount == 0) //클리어 판정이 안나고 초기화하면.
            {
                pieceCount = 0;
                boxcol.enabled = false;
                TGV_UI[6].SetActive(false);
                GameManager.Instance.startMission = false;
                TGV_TGV_UI_bool(false);
                TGV_TGV_bool(true);
            }
        }

        Debug.Log(GameManager.Instance.missionCount);

        if (GameManager.Instance.missionCount == 0)
            boxcol.enabled = true;


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
                pieceCount += 1;
                getfalse(0); //머리를 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Bd")
            {
                pieceCount += 1;
                getfalse(1); // 몸을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_La")
            {
                pieceCount += 1;
                getfalse(2); // 왼팔을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Ra")
            {
                pieceCount += 1;
                getfalse(3); // 오른팔을 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Li")
            {
                pieceCount += 1;
                getfalse(4); // 왼다리를 클릭했다.
            }
            if (Click.ReturnName() == "TGV_Ri")
            {
                pieceCount += 1;
                getfalse(5); // 오른다리를 클릭했다.
            }

            if (pieceCount == 6) //6개를 다 모으면 뭐.. 이미지 등장
            {
                TGV_TGV_VSXZ_bool(true);

                GameManager.Instance.missionCount += 1;
                GameManager.Instance.startMission = false;
            }
        }
    }

    void getfalse(int getObj)
    {
        TGV[getObj].enabled = false; //배치 obj col은 비활하고
        TGV_UI[getObj].SetActive(true); //ui sprite는 활성
        Debug.Log(Click.ReturnName());
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
