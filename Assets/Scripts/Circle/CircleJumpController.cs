﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float circleJumpForce;
    [SerializeField] private CircleDataTransmitter circleDataTransmitter;
        // Update is called once per frame
    
    void FixedUpdate()
    {
        SetCircleJump();
    }


    private void SetCircleJump()
    {
        if (circleDataTransmitter.GetIsTouch())
        {
            rb.velocity = Vector2.up * circleJumpForce * Time.fixedDeltaTime;

        }
    }
}
