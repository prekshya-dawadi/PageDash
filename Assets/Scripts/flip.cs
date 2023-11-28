using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class flip : MonoBehaviour
{
    private Vector3 rotationVector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationVector = new Vector3(0,90,0);
        transform.Rotate(rotationVector*Time.deltaTime);    
    }
}
