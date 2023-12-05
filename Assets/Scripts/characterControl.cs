using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    float top_boundary, bottom_boundary, left_boundary, right_boundary, movement_rate;

    void Start()
    {
        top_boundary = -0.62f;
        bottom_boundary = -3.5f;
        left_boundary = -5.0f;
        right_boundary = -0.77f;
        movement_rate = 1.5f;
    }

    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (transform.position.z >= top_boundary)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, movement_rate);
            }
        }
        if (Input.GetKey("down"))
        {
            if (transform.position.z <= bottom_boundary)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -movement_rate);
            }
        }
        if (Input.GetKey("right"))
        {
            if (transform.position.x >= right_boundary)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(movement_rate, 0, 0);

            }
        }
        if (Input.GetKey("left"))
        {
            if (transform.position.x <= left_boundary)
            {
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

            }
            else
            {
                GetComponent<Rigidbody>().velocity = new Vector3(-movement_rate, 0, 0);

            }
        }
    }

}



