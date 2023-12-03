using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControl : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey("up")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,2);
        }
        if (Input.GetKey("down")){
            GetComponent<Rigidbody>().velocity = new Vector3(0,0,-2);
        }
        if (Input.GetKey("right")){
            GetComponent<Rigidbody>().velocity = new Vector3(2,0,0);
        }
        if (Input.GetKey("left")){
            GetComponent<Rigidbody>().velocity = new Vector3(-2,0,0);
        }
    }
}
