﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    float maxDist = 15.0f;
    Vector3 mousePos;
    static RaycastHit2D hit; //static
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        if (/*Input.GetMouseButtonDown(0)||*/Input.GetMouseButtonUp(0))
        {
            mousePos = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mousePos);

            hit = Physics2D.Raycast(mousePos, transform.forward, maxDist);


            if (hit.collider !=null)
            {
                GameManager.Instance.isClick = true;
                Debug.Log("isClick is " + GameManager.Instance.isClick);
            }
        }
        else// if(Input.GetMouseButton(0))
        {
            GameManager.Instance.isClick = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    static public string ReturnName()
    {
            return hit.collider.gameObject.name;
    }
    static public string ReturnTag()
    {
            return hit.collider.gameObject.tag;
    }
}
