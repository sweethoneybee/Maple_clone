using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mush_jump : MonoBehaviour
{
    Animator animator;
    bool isJump;

    void Start()
    {
        animator = GetComponent<Animator>();
        isJump = false;    
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        if (Input.GetButton("Vertical") == true)
        { 
            transform.Translate(new Vector3(0, v, 0) * Time.deltaTime);
        }
    }
}
