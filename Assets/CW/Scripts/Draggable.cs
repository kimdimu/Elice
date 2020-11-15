﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

}
