using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush_jump : MonoBehaviour
{
    Animator animator;
    bool isJump;
    Rigidbody rb;
    public int jumpPower;
    void Start()
    {
        animator = GetComponent<Animator>();
        isJump = false;
        rb = GetComponent<Rigidbody>();
        jumpPower = 2;
    }

    private void FixedUpdate()
    {
        if(Input.GetButton("Vertical") == true && isJump == false)
        {
            isJump = true;
            rb.AddForce(new Vector2(0, jumpPower), ForceMode.Impulse);
        }

        if(rb.velocity.y <= 0)
        {
            isJump = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //float v = Input.GetAxis("Vertical");
        //if (Input.GetButton("Vertical") == true)
        //{ 
        //    transform.Translate(new Vector3(0, v, 0) * Time.deltaTime);
        //}
    }
}
