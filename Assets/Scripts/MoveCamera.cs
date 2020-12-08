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

    void Update()
    {
        if (GameManager.Instance.isMonocle == true) //모노클 이동
        {
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,0));
            followingCursor.transform.position = new Vector3(newPosition.x, newPosition.y, -3f);
        }


        transform.position = new Vector3(target.position.x, target.position.y+3,transform.position.z);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9.32f, 51.3f), Mathf.Clamp(transform.position.y, -20.0f, 20.0f), Mathf.Clamp(transform.position.z, -15.0f, 0)); //이동범위제한
    }
}
