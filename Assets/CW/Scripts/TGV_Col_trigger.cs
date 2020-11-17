using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGV_Col_trigger : MonoBehaviour
{
    public GameObject[] VSXZ;
    float Posx = -3;
    float Posy = 0;

    private void Start()
    {
        chogihwa();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Correct")
        {
            GameManager.Instance.clear = true;
            Debug.Log("Correct");
        }
        else
        {
            chogihwa();
            //Draggable.isDrag = false;
            GameManager.Instance.startMission = false;
            Debug.Log("NonCorrect");
        }
    }

    void chogihwa()
    {
        for (int i = 0; i < VSXZ.Length; i++)
        {
            if (i == 0)
            {
                Posx = -3;
            }

            VSXZ[i].transform.position = new Vector3(Posx, Posy, -4);
            Posx += 2;
        }

    }
}
