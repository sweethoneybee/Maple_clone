using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush_jump : MonoBehaviour
{
    Animator animator;
    bool isJump;
    Rigidbody2D rb;
    public int jumpPower;

    public double v_y;
    void Start()
    {
        animator = GetComponent<Animator>();
        isJump = false;
        rb = GetComponent<Rigidbody2D>();
        jumpPower = 300;
    }

    //private void FixedUpdate()
    //{ 
    //    if(Input.GetKeyDown(KeyCode.UpArrow) == true && isJump == false)
    //    {
    //        isJump = true;
    //        //rb.AddForce(new Vector2(0, jumpPower), ForceMode.Impulse);
    //        rb.AddForce(new Vector2(0, jumpPower));
    //    }

    //}
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true && isJump == false)
        {
            Debug.Log("wow");
            isJump = true;
            //rb.AddForce(new Vector2(0, jumpPower), ForceMode.Impulse);
            rb.AddForce(new Vector2(0, jumpPower));
        }
        if(rb.velocity.y == 0)
        {
            isJump = false;
        }
        else
        {
            isJump = true;
        }
        animator.SetBool("isJump", isJump);

        // only for speed check
        v_y = rb.velocity.y;
    }
}
