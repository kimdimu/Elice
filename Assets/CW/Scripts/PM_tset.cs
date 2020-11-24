using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM_tset : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
    }
}
