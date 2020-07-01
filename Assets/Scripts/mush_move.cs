using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush_move : MonoBehaviour
{
    
    Animator animator;

    bool isJump;
    bool isMove;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
        isJump = false;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, 0f);
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if(Input.GetButtonDown("Fire1"))
            isJump = !isJump;

        
        if(Input.GetButton("Horizontal")){
            int dir;
            Vector3 characterScale = transform.localScale;
            if(h > 0){
                dir = 1;
                characterScale.x = -2;
            }
            else{
                dir = -1;
                characterScale.x = 2;
            }
            transform.Translate(new Vector3(dir, 0, 0) * speed * Time.deltaTime);

            // flip
            transform.localScale = characterScale;

            // for move animator
            isMove = true;
        }
        else
        {
            isMove = false;
        }
        // if(h < 0){
        //     transform.Translate(Vector3.left * Time.deltaTime);
        //     //transform.position = new Vector3(0, 0, transform.position.z);
        // }


        // animator
        animator.SetBool("isJump", isJump);
        animator.SetBool("isMove", isMove);
    }
}

