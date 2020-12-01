using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
  
     public float speed;
    Rigidbody2D rigid;
    public SpriteRenderer rend;
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
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -12.0f, 52.0f), transform.position.y, transform.position.z); //이동범위제한

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("TitleScene");
        }

        if (!GameManager.Instance.isMonocle)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position = transform.position - transform.right * Time.deltaTime * speed;  //왼쪽이동
                rend.flipX = false;                                                                 //좌우반전
                anim.SetBool("IsWalking", true);
            }

            else if (Input.GetKey(KeyCode.D))
            {
                transform.position = transform.position + transform.right * Time.deltaTime * speed; //오른쪽이동
                rend.flipX = true;                                                                //좌우반전
                anim.SetBool("IsWalking", true);
            }
            else if (Input.GetKeyUp(KeyCode.A))
            {
                anim.SetBool("IsWalking", false);
            }

            else if (Input.GetKeyUp(KeyCode.D))
            {
                anim.SetBool("IsWalking", false);
            }
        }
    }

}
