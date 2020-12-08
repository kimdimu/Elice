using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class train : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Train;
    public GameObject Walls;
    public GameObject Map;

    public GameObject LTrain;
    public GameObject Earth;
    public GameObject Black;
    public GameObject Pro;


    private float CDist;
    private float BDist;
    private float PDist;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isMonocle == true && GameManager.Instance.isClick )
        {
          
          Train.SetActive(true);
            Walls.SetActive(true);
            Map.SetActive(true);
            Earth.SetActive(true);
        }
        else if (GameManager.Instance.isMonocle == false)
        {
            Train.SetActive(false);
            Walls.SetActive(false);
            Map.SetActive(false);
            Earth.SetActive(false);
            LTrain.SetActive(false);
        }
        else if (GameManager.Instance.isMonocle == true)
        {
            LTrain.SetActive(true);
        }

        CDist = Vector3.Distance(Train.transform.position, Earth.transform.position);
        BDist = Vector3.Distance(Train.transform.position, Black.transform.position);
        PDist = Vector3.Distance(Train.transform.position, Pro.transform.position);
        if (CDist <= 0.5) //지구도착
        {
            Debug.Log("clear");
        }
        else if (BDist <= 0.5) //블랙홀 도착
        {
            Debug.Log("fail");
            Train.transform.position = new Vector3(-2.82f, 4.29f, -1f);
        }

        else if (PDist <= 1) //프로메슘 도착
        {
            Debug.Log("fail");
            Train.transform.position = new Vector3(-2.82f, 4.29f, -1f);
        }


    }
    

}
