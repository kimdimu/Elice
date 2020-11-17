using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningMonocle : MonoBehaviour
{
    // Start is called before the first frame update

   
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
    

 

        if (Input.GetKeyDown(KeyCode.Space))
        {
          

            if (GameManager.Instance.isMonocle == true)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);  //z=0 으로 이동



                GameManager.Instance.isMonocle = false;             //모노클 꺼짐
                Debug.Log("false");
                return;
            }

            else if (GameManager.Instance.isMonocle == false)
            {
                transform.position += Vector3.back *10; //z=-10으로 이동
                GameManager.Instance.isMonocle = true;              //모노클 켜짐
                Debug.Log("On");
                return;
            }
        }
    }
}
