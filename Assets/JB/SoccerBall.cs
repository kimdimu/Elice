using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //WorldCup worldCup = GameObject.Find("Ra1").GetComponent<WorldCup>();
       
    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Vector2 wc = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Ray2D ray2 = new Ray2D(wc, Vector2.zero);
            //RaycastHit2D hit2 = Physics2D.Raycast(ray2.origin, ray2.direction);
            //if (hit2.collider != null)
            if(GameManager.Instance.isClick)
            {
                if(WorldCup.WB.WC == true)
                {
                    //성공
                    Debug.Log("clear");
                }
                else
                {
                    //실패
                    Debug.Log("fail");
                }
            }
        }
    }
}
