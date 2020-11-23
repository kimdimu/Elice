using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningMonocle : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject dining1;
    public GameObject dining2;
    public GameObject monocle;

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
               

                dining1.SetActive(true);
                dining2.SetActive(false);
                monocle.SetActive(false);


                GameManager.Instance.isMonocle = false;             //모노클 꺼짐
                Debug.Log("false");
                return;
            }

            else if (GameManager.Instance.isMonocle == false)
            {
              

                dining1.SetActive(false);
                dining2.SetActive(true);
                monocle.SetActive(true);


                GameManager.Instance.isMonocle = true;              //모노클 켜짐
                Debug.Log("On");
                return;
            }
        }
    }
}
