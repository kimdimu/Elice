using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningMonocle : MonoBehaviour
{
    // Start is called before the first frame update

   // public GameObject dining1;
    //public GameObject dining2;
    public GameObject monocle;
 

    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameManager.Instance.isMonocle + "monooff");

        if (GameManager.Instance.isMonocle == true)
        {
            monocle.SetActive(true);
            //dining1.SetActive(false);
            //dining2.SetActive(true);
           

        }
        else
        {
            //dining1.SetActive(true);
            //dining2.SetActive(false);
            monocle.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //모노클 꺼짐
            if (GameManager.Instance.isMonocle == true)
            {
                GameManager.Instance.isMonocle = false;
            }
            //모노클 켜짐
            else
            {
                GameManager.Instance.isMonocle = true;
            }
        }
    }
}
