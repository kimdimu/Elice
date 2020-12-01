using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCup : MonoBehaviour
{
    public GameObject Devil1;
    public GameObject Devil2;
    public GameObject Devil3;
    public GameObject Devil4;
    public GameObject RedDevil;

    public static WorldCup WB;
    public bool WC = false;

    // Start is called before the first frame update
    void Start()
    {
        WB = this;
    }

    // Update is called once per frame

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Ray2D ray = new Ray2D(wp, Vector2.zero);
            //RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            //if (hit.collider != null)
            if(GameManager.Instance.isClick && Click.ReturnTag() == "RedDevilDoll")
            {
                int ran = Random.Range(0, 6);
                //Random.Range(0, 6);

                if (ran == 1)           //붉은악마는 1번
                {
                    Devil1.gameObject.SetActive(false);
                    Devil2.gameObject.SetActive(false);
                    Devil3.gameObject.SetActive(false);
                    Devil4.gameObject.SetActive(false);
                    RedDevil.gameObject.SetActive(true);

                    WC = true;
                }
                else if (ran == 2)
                {
                    Devil1.gameObject.SetActive(true);
                    Devil2.gameObject.SetActive(false);
                    Devil3.gameObject.SetActive(false);
                    Devil4.gameObject.SetActive(false);
                    RedDevil.gameObject.SetActive(false);

                    WC = false;
                }
                else if (ran == 3)
                {
                    Devil1.gameObject.SetActive(false);
                    Devil2.gameObject.SetActive(true);
                    Devil3.gameObject.SetActive(false);
                    Devil4.gameObject.SetActive(false);
                    RedDevil.gameObject.SetActive(false);

                    WC = false;
                }
                else if (ran == 4)
                {
                    Devil1.gameObject.SetActive(false);
                    Devil2.gameObject.SetActive(false);
                    Devil3.gameObject.SetActive(true);
                    Devil4.gameObject.SetActive(false);
                    RedDevil.gameObject.SetActive(false);

                    WC = false;
                }
                else if (ran == 5)
                {
                    Devil1.gameObject.SetActive(false);
                    Devil2.gameObject.SetActive(false);
                    Devil3.gameObject.SetActive(false);
                    Devil4.gameObject.SetActive(true);
                    RedDevil.gameObject.SetActive(false);

                    WC = false;
                }

            }
        }






    }
    
}
