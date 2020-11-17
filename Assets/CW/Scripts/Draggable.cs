using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour
{
    bool isDrag;

    public BoxCollider2D[] VSXZ;

    private void Start()
    {
        isDrag = false;
    }

    private void Update()
    {
        Debug.Log(isDrag);
        if (isDrag)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePos);
            //transform.position = Input.mousePosition;
        }
    }
    void VSXZ_bool(bool booll)
    {
        for (int i = 0; i < VSXZ.Length; i++)
        {
            VSXZ[i].enabled = booll;
        }
    }
    public void OnMouseDown()
    {
        isDrag = true;
        VSXZ_bool(false);
    }

    public void OnMouseUp()
    {
        isDrag = false;
        VSXZ_bool(true);
    }
}
