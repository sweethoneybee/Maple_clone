﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public float gravity = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, gravity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
