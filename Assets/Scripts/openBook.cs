using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class openBook : MonoBehaviour
{
    [SerializeField]

    private Vector3 rotationVector;
    private bool spaceDown = false;
    private DateTime startTime;
    private DateTime endTime;
    // private RigidBody rb;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space")){
            space_down();
        }
        
        if (spaceDown == true){
            transform.Rotate(rotationVector*Time.deltaTime);
            endTime = DateTime.Now;

            if ((endTime - startTime).TotalSeconds>=1)
            {
                spaceDown = false;
            }    
        }
    }

    void space_down(){
        spaceDown = true;
        rotationVector = new Vector3(0,90,0);
        startTime = DateTime.Now;
    }
}
