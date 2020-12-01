using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMF_AI : MonoBehaviour
{
    public GameObject center;
    public float sphereDist;
    public float lerpT;
    public float dist;
    Vector3 randomPos;
    void Start()
    {
        sphereDist = 2;
        lerpT = 0.1f;
        dist = 0.1f;
        randomPos = transform.position;
    }

    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(randomPos.x, randomPos.y, -2), lerpT);


        if (Vector2.Distance(transform.position, randomPos) < dist)
        {
            randomPos = center.transform.position + Random.insideUnitSphere * sphereDist;
        }
    }
}
