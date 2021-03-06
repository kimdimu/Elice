﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gul88 : MonoBehaviour
{
    public BoxCollider2D boxcol;
    public GameObject monocleObj;
    //public GameObject boy;
    public GameObject parentObj;
    public BoxCollider2D []gull_boy_obj;
    public Vector3 []gull_boy_obj_pos;

    public GameObject[] redImg;

    bool getobj;
    int obj_Count;

    void Start()
    {
        redImg[0].SetActive(false);
        redImg[1].SetActive(false);
        obj_Count = 5;
        getobj = false;
        Gull_init(false); //일단 모두 가리기
        //monocleObj.SetActive(false);

        for (int i = 0; i < gull_boy_obj_pos.Length; i++) //초기 위치 저장, 그 저장한 위치에 위치시키기
        {
            gull_boy_obj_pos[i] = gull_boy_obj[i].transform.position;
            gull_boy_obj[i].transform.position = gull_boy_obj_pos[i];
        }
    }

    void Update()
    {
        Debug.Log(getobj);

        if (!GameManager.Instance.startMission) //미션 상태가 아닐 때 위치 초기화
        {
            for (int i = 0; i < gull_boy_obj_pos.Length; i++)
            {
                getobj = false;
                gull_boy_obj[i].transform.position = gull_boy_obj_pos[i];
            }

            obj_Count = 5;
        }

        if (GameManager.Instance.isMonocle)
        {
            redImg[0].SetActive(false);
            redImg[1].SetActive(false);
            if (GameManager.Instance.missionCount == 2)
            {
                boxcol.enabled = true;
                monocleObj.SetActive(true);
            }
        }
        else
        {
            monocleObj.SetActive(false);
        }

        if (GameManager.Instance.missionCount == 2 && GameManager.Instance.startMission) //2일 때 모두 온
        {
            Gull_init(true); //미션 시작 시 트루됨

            if (GameManager.Instance.isClick && Click.ReturnTag() == "Gull_Obj")
            {
                GetSound.instance.playSound();
                   getobj = true;
                Debug.Log("Tag gull obj");

                if (Click.ReturnName() == "굴렁쇠")
                    obj_Count = 0;
                else if (Click.ReturnName() == "야구공")
                    obj_Count = 1;
                else if (Click.ReturnName() == "clock")
                    obj_Count = 2;
                else if (Click.ReturnName() == "줄넘기")
                    obj_Count = 3;
                else if (Click.ReturnName() == "화분")
                    obj_Count = 4;
            }
            else
            {
                getobj = true;
            }
        }

        if (getobj)
        {
            if (Vector3.Distance(gull_boy_obj[obj_Count].transform.position, monocleObj.transform.position) >= 2.0f)
            {
                GobackPos();//자리 초기화
                gull_boy_obj[obj_Count].transform.position = Vector3.Lerp(gull_boy_obj[obj_Count].transform.position, parentObj.transform.position, 0.2f);
            }
            else
            {
                gull_boy_obj[obj_Count].transform.position = Vector3.Lerp(gull_boy_obj[obj_Count].transform.position, monocleObj.transform.position, 0.05f);
            }
        }
        Gull_Clear();
    }

    void Gull_init(bool mission) //초기화
    {
        boxcol.enabled = mission; //콜라이더
        monocleObj.SetActive(mission); //enable

        for (int i = 0; i < gull_boy_obj.Length; i++)
        {
            gull_boy_obj[i].enabled = mission; // 물건 5개col 부모
        }
    }

    void GobackPos()
    {
        for (int i = 0; i < gull_boy_obj.Length; i++)
        {
            if (i != obj_Count) //지금 선택하고 있는것 제외한 나머지 제자리
                gull_boy_obj[i].transform.position = Vector3.Lerp(gull_boy_obj[i].transform.position, gull_boy_obj_pos[i],0.5f);
        }
    }

    void Gull_Clear()
    {
        if(Vector3.Distance(gull_boy_obj[0].transform.position, monocleObj.transform.position) <= 0.02f)//( == )
        {
            GameManager.Instance.clear=true;
        }

        if (Vector3.Distance(gull_boy_obj[1].transform.position, monocleObj.transform.position) <= 0.02f || Vector3.Distance(gull_boy_obj[2].transform.position, monocleObj.transform.position) <= 0.02f
            || Vector3.Distance(gull_boy_obj[3].transform.position, monocleObj.transform.position) <= 0.02f || Vector3.Distance(gull_boy_obj[4].transform.position, monocleObj.transform.position) <= 0.02f)
        {
            GameManager.Instance.startMission = false;
            redImg[0].SetActive(true);
            redImg[1].SetActive(true);
            MissionManager.missionfailsound();
        }
    }
}
