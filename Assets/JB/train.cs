using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Train;
    public GameObject Walls;
    public GameObject Map;
    public GameObject dark;

    public GameObject LTrain;
    public GameObject Earth;
    public GameObject Black;
    public GameObject Pro;

    public GameObject player;

    public GameObject[] redImg;

    Vector3 nowPos;
    private float CDist;
    private float BDist;
    private float PDist;

    void Start()
    {
        redImg[0].SetActive(false);
        redImg[1].SetActive(false);
        nowPos = Train.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.startMission)
        {
            player.transform.localScale = new Vector3(1, 1, 1);
            Train.transform.position = nowPos; //기차위치 초기화
            Train.SetActive(false);
            Walls.SetActive(false);
            Map.SetActive(false);
            Earth.SetActive(false);
            LTrain.SetActive(false);
            dark.SetActive(false);
        }

        if (GameManager.Instance.startMission && GameManager.Instance.missionCount == 1)// && GameManager.Instance.isClick)
        {
            player.transform.position = new Vector3(38.5f, -3, 0);
            player.transform.localScale = new Vector3(0.5f, 0.5f, 1);
            dark.SetActive(true);
            Train.SetActive(true);
            Walls.SetActive(true);
            Map.SetActive(true);
            Earth.SetActive(true);

            dark.transform.position = Train.transform.position;
        }

        if (GameManager.Instance.isMonocle == true && GameManager.Instance.missionCount == 1)
        {
            LTrain.SetActive(true);
            redImg[0].SetActive(false);
            redImg[1].SetActive(false);
        }
        else if (GameManager.Instance.isMonocle == false)
        {
            LTrain.SetActive(false);
        }

        CDist = Vector3.Distance(Train.transform.position, Earth.transform.position);
        BDist = Vector3.Distance(Train.transform.position, Black.transform.position);
        PDist = Vector3.Distance(Train.transform.position, Pro.transform.position);

        if (CDist <= 0.5) //지구도착
        {
            GameManager.Instance.clear = true;
        }
        else if (BDist <= 0.5) //블랙홀 도착
        {
            Debug.Log("fail");
            GameManager.Instance.startMission = false;
            redImg[0].SetActive(true);
            redImg[1].SetActive(true);
        }

        else if (PDist <= 1) //프로메슘 도착
        {
            Debug.Log("fail");
            GameManager.Instance.startMission = false;
            redImg[0].SetActive(true);
            redImg[1].SetActive(true);
        }


    }
    

}
