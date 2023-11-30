using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class flipPage : MonoBehaviour
{
    [SerializeField]

    private Vector3 rotationVector;
    private DateTime startTime;
    private DateTime endTime;
    private bool flip = false;

    // Start is called before the first frame update
    void Start()
    {
        Rotate();
    }

    // Update is called once per frame
    void Update()
    {
        if (flip == true)
        {
            transform.Rotate(rotationVector * Time.deltaTime);
            endTime = DateTime.Now;

            if ((endTime - startTime).TotalSeconds >= 1.5)
            {
                flip = false;
            }
        }

    }

    void Rotate(){
        startTime = DateTime.Now;
        rotationVector = new Vector3(0, 90, 0);
        flip = true;
    }
}
