using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush_move : MonoBehaviour
{
    Animator animator;
    bool isJump;
    public float speed = 2;

    void Start()
    {
        animator = GetComponent<Animator>();    
        isJump = false;
    }

    void Update()
    {
        // temp jump animation
        if(Input.GetButtonDown("Fire1"))
            isJump = !isJump;

        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Move
        bool isMove;
        if(Input.GetButton("Horizontal")){
            int dir = MoveHorizontal(h);
            SpriteFlip(dir, 2, -2);
            isMove = true;
        }
        else
        {
            isMove = false;
        }

        // animator
        animator.SetBool("isJump", isJump);
        animator.SetBool("isMove", isMove);
    }

    private int MoveHorizontal(float h)
    {
        int dir;
        if (h == 0)
        {
            dir = 0;
        }
        else if (h > 0)
        {
            dir = 1;
        }
        else
        {
            dir = -1;
        }
        transform.Translate(new Vector3(dir, 0, 0).normalized * speed * Time.deltaTime);
        return dir;
    }
    private bool SpriteFlip(int dir, int leftScale, int rightScale)
    {
        Vector3 spriteScale = transform.localScale;
        bool isMove;
        if (dir == 0)
        {
            isMove = false;
        }
        else if (dir > 0)
        {
            isMove = true;
            spriteScale.x = rightScale;
        }
        else
        {
            isMove = true;
            spriteScale.x = leftScale;
        }
        transform.localScale = spriteScale;
        return isMove;
    }
}

