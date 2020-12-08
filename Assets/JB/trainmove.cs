using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmove : MonoBehaviour
{

    public float trainspeed;

    Vector3 camPos;

    void Update()
    {
        if (GameManager.Instance.startMission && GameManager.Instance.missionCount == 1)
        {
            //기차의 위치는 마우스위치를 월드로 변환한 좌표이다.
            Vector3 test = (camPos - transform.position).normalized;

            camPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);// * Time.deltaTime * trainspeed;
            transform.Translate(test.x*Time.deltaTime *trainspeed, test.y * Time.deltaTime * trainspeed,0);

            //if (Input.GetKey(KeyCode.A))
            //{
            //    transform.position = transform.position - transform.right * Time.deltaTime * trainspeed;
            //}
            //else if (Input.GetKey(KeyCode.D))
            //{
            //    transform.position = transform.position + transform.right * Time.deltaTime * trainspeed;
            //}
            //else if (Input.GetKey(KeyCode.W))
            //{
            //    transform.position = transform.position + transform.up * Time.deltaTime * trainspeed;
            //}
            //else if (Input.GetKey(KeyCode.S))
            //{
            //    transform.position = transform.position - transform.up * Time.deltaTime * trainspeed;
            //}
        }
        }
}
