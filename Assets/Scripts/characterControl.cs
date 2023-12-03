using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    Rigidbody rb;
    float top_boundary, bottom_boundary, left_boundary, right_boundary, movement_rate;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        top_boundary = -0.62f; 
        bottom_boundary = -3.2f; 
        left_boundary = -4.85f;  
        right_boundary = -0.77f;  
        movement_rate = 3;
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (transform.position.z <= top_boundary)
            {
                rb.velocity = new Vector3(0, 0, movement_rate);
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
        if (Input.GetKey("down"))
        {
            if (transform.position.z >= bottom_boundary)
            {
                rb.velocity = new Vector3(0, 0, -movement_rate);
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
        if (Input.GetKey("right"))
        {
            if (transform.position.x <= right_boundary)
            {
                rb.velocity = new Vector3(movement_rate, 0, 0);
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
        if (Input.GetKey("left"))
        {
            if (transform.position.x >= left_boundary)
            {
                rb.velocity = new Vector3(-movement_rate, 0, 0);
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
