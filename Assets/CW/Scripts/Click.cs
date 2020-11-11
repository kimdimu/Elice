using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    float maxDist = 15.0f;
    Vector3 mousePos;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        Debug.Log(GameManager.Instance.isClick);
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos = cam.ScreenToWorldPoint(mousePos);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, transform.forward, maxDist);

            GameManager.Instance.isClick = true;
        }
        else if(Input.GetMouseButton(0))
        {
            GameManager.Instance.isClick = false;
        }
    }
}
