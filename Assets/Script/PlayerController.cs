﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveHorizonal;
    public float moveVertical;
    public float moveJump;

    public float Yaxis = 0;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveHorizonal, moveJump, moveVertical);
        rb.AddForce(transform.forward.normalized * moveVertical);
        rb.AddForce(transform.right.normalized * moveHorizonal);
        rb.AddForce(transform.up.normalized * moveJump);
        //rb.AddForce(movement);
        if (transform.position.y >= Yaxis)
        {
            moveJump = 0.0f;                // 중력 가속도 적용(기본적으로 물체 RigidBody에서 중력 적용되어 있음)
            Yaxis = 0;
        }
    }

    public void Jump()
    {
        moveJump = 19.82f;                  // 중력 가속도 반작용 힘
        Yaxis = transform.position.y + 1;   // 높이 조절. 
    }
    
}
