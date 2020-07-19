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
        jumpPower = 200;
    }

    private void FixedUpdate()
    {
        if(Input.GetButton("Vertical") == true && isJump == false)
        {
            isJump = true;
            //rb.AddForce(new Vector2(0, jumpPower), ForceMode.Impulse);
            rb.AddForce(new Vector2(0, jumpPower));
        }

        if(rb.velocity.y == 0)
        {
            isJump = false;
        }
        v_y=  rb.velocity.y;
    }
    // Update is called once per frame
    void Update()
    {
        //float v = Input.GetAxis("Vertical");
        //if (Input.GetButton("Vertical") == true)
        //{ 
        //    transform.Translate(new Vector3(0, v, 0) * Time.deltaTime);
        //}
        animator.SetBool("isJump", isJump);
    }
}
