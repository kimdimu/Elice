using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwangJu80 : MonoBehaviour
{
    public BoxCollider2D boxcol;
    
    void Start()
    {
        
    }
    void Update()
    {

        if (GameManager.Instance.missionCount == 1)
            boxcol.enabled = true;
        else
        {
            boxcol.enabled = false;
        }
    }
}
