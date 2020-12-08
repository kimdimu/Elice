using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
  
     public float speed;
    Rigidbody2D rigid;
    SpriteRenderer rend;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        rend = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -18.32f, 60.0f), transform.position.y, transform.position.z); //이동범위제한

        if (!GameManager.Instance.isMonocle)
        {
            float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            transform.Translate(h, 0, 0);


            if (h > 0.0f)
            {
                rend.flipX = true;
                anim.SetBool("IsWalking", true);
            }
            else if (h < 0.0f)
            {
                rend.flipX = false;
                anim.SetBool("IsWalking", true);
            }
            else
            {
                anim.SetBool("IsWalking", false);
            }
            //if (Input.GetKeyDown(KeyCode.A))
            //{
            //    transform.position = transform.position - transform.right * Time.deltaTime * speed;  //왼쪽이동
            //    rend.flipX = false;                                                                 //좌우반전
            //    anim.SetBool("IsWalking", true);
            //}
            //else
            //{
            //    anim.SetBool("IsWalking", false);
            //}

            //if (Input.GetKeyDown(KeyCode.D))
            //{
            //    transform.position = transform.position + transform.right * Time.deltaTime * speed; //오른쪽이동
            //    rend.flipX = true;                                                                //좌우반전
            //    anim.SetBool("IsWalking", true);
            //}
            //else
            //{
            //    anim.SetBool("IsWalking", false);
            //}
            //else if (Input.GetKeyUp(KeyCode.A))
            //{
            //    anim.SetBool("IsWalking", false);
            //}

            //else if (Input.GetKeyUp(KeyCode.D))
            //{
            //    anim.SetBool("IsWalking", false);
            //}
        }
        else
            anim.SetBool("IsWalking", false);
    }


}
