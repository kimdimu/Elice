using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TGV_Col_trigger : MonoBehaviour
{
    public GameObject[] VSXZ;
    public GameObject player;
    float Posx = -3;
    float Posy = 0;

    public GameObject[] redImg;

    private void Start()
    {
        redImg[0].SetActive(false);
        redImg[1].SetActive(false);
        chogihwa();
    }

    private void Update()
    {
        if (GameManager.Instance.isMonocle)
        {
            redImg[0].SetActive(false);
            redImg[1].SetActive(false);
        }

        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
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
            redImg[0].SetActive(true);
            redImg[1].SetActive(true);
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
