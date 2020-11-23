using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static private GameManager instance = null;

    static public GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject container = new GameObject();
                container.name = "SGT CTN";
                instance = container.AddComponent(typeof(GameManager)) as GameManager;
            }

            return instance;
        }
        set
        {
            instance = value;
        }
    }

    public bool isClick;
    public bool isMonocle;
    public int missionCount;
    public bool startMission;
    //public bool missioning;
    public bool clear;


    void Start()
    {
        missionCount = 0;
        startMission = false;
        isMonocle = false;
        isClick = false;
        //missioning = false;
        clear = false;
    }

    void Update()
    {
        
    }
}
