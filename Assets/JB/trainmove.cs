using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmove : MonoBehaviour
{
    // Start is called before the first frame update

    public float trainspeed;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isMonocle == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = transform.position - transform.right * Time.deltaTime * trainspeed;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.position = transform.position + transform.right * Time.deltaTime * trainspeed;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                transform.position = transform.position + transform.up * Time.deltaTime * trainspeed;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.position = transform.position - transform.up * Time.deltaTime * trainspeed;
            }
        }
        }
}
