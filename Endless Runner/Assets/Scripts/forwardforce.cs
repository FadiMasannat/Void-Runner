﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forwardforce : MonoBehaviour
{

    public Rigidbody rb;
    public float Sideforce = 500f;
    public float ForwardForce = 2000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime); 

        if (Input.GetKey("d"))
        {
            rb.AddForce(Sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
