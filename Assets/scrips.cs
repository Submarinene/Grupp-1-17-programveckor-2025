using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlattformPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public int accelerationSpeed;
    public int maxSpeed;
    public float friction;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        //R�relse
        if (Input.GetKey(KeyCode.RightArrow))
        {


            if (rb.linearVelocity.x < maxSpeed)
            {
                rb.linearVelocity = rb.linearVelocity + new Vector2(accelerationSpeed * Time.deltaTime, 0);
            }
            else
            {
                rb.linearVelocity = new Vector2(maxSpeed, 0);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (rb.linearVelocity.x > -maxSpeed)
            {
                rb.linearVelocity = rb.linearVelocity + new Vector2(-accelerationSpeed * Time.deltaTime, 0);
            }
            else
            {
                rb.linearVelocity = new Vector2(-maxSpeed, 0);
            }
        }
        
    }
}
