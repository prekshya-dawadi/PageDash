using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class flip : MonoBehaviour
{
    [SerializeField]
    Button startBtn;
    private Vector3 rotationVector;
    bool startBtnClicked = false;
    // Start is called before the first frame update
    void Start()
    {
        if (startBtn != null){
            startBtn.onClick.AddListener(()=>startBtn_Click());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (startBtnClicked = true){
            transform.Rotate(rotationVector*Time.deltaTime);    
        }
    }

    void startBtn_Click(){
        startBtnClicked = true;
        rotationVector = new Vector3(0,90,0);
    }
}
