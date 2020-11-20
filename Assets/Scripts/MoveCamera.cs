using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public GameObject followingCursor;

    private float initialZPos = 0f;

    void Start()
    {
        initialZPos = followingCursor.transform.position.y;
    }

    void LateUpdate()
    {
        if (GameManager.Instance.isMonocle == true) //모노클 이동
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -11f));
            followingCursor.transform.position = new Vector3(newPosition.x, newPosition.y-0.6f, -11f);
        }


        transform.position = new Vector3(target.position.x, target.position.y+3,target.position.z-5f);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5.0f, 5.0f), Mathf.Clamp(transform.position.y, -20.0f, 20.0f), Mathf.Clamp(transform.position.z, -15.0f, 1.0f)); //이동범위제한
    }
}
