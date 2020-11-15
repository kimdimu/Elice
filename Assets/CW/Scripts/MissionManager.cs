using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    public GameObject []mcImg;
    public GameObject []mcImg_end;
    public Text text;

    void Start()
    {
        for (int i = 0; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(false);
        }
        for (int i = 0; i < mcImg_end.Length; i++)
        {
            mcImg_end[i].SetActive(false);
        }
    }

    void Update()
    {
        if (GameManager.Instance.isClick && Click.ReturnTag() == "MonocleObj") //+ 모노튼 착용상태면
        {
            missionImg();
            StartMissionImg();
            text.text = "Find Memory";
        }

        if (GameManager.Instance.clear) //클리어면
        {
            missionImg(); //배경, 버튼 뜨고
            EndMissionImg(); //엔드 이미지 텍스트 뜨고
            text.text = "Go to Next"; // 버튼 텍스트 변경하고
        }
    }
 
    void missionImg() //배경과 버튼 나오게 하는 함수
    {
        //GameManager.Instance.missioning = true; //이 ui가 켜졌다.
        GameManager.Instance.startMission = false; //미션중이 아니다.

        for (int i = 0; i < 2; i++)
        {
            mcImg[i].SetActive(true);
        }
        
        Debug.Log(GameManager.Instance.missionCount);
    }

    void StartMissionImg() //미션 시작 시 추가되는 스테이지별 이미지와 텍스트
    {
        mcImg[GameManager.Instance.missionCount + 2].SetActive(true); //스테이지에 맞는 텍스트 출력
    }

    void EndMissionImg() //미션 종료 시 추가되는 스테이지별 이미지와 텍스트
    {
        mcImg_end[GameManager.Instance.missionCount].SetActive(true);
    }

    public void missionImgOff() //모든 미션 ui을 끈다. 버튼을 누르면 이렇게 됨.
    {
        //UI 끄는 코드
        for (int i = 0; i < mcImg.Length; i++)
        {
            mcImg[i].SetActive(false);
        }
        for (int i = 0; i < mcImg_end.Length; i++)
        {
            mcImg_end[i].SetActive(false);
        }

        //GameManager.Instance.missioning = false; //미션 ui가 꺼졌다.

        if (!GameManager.Instance.clear) //클리어가 아니면
        {
            GameManager.Instance.startMission = true; //미션중이다.
        }
        else if (GameManager.Instance.clear)
        {
            GameManager.Instance.missionCount += 1; //다음 스테이지 이동하고
            GameManager.Instance.clear = false; //클리어 초기화
        }
    }
}
