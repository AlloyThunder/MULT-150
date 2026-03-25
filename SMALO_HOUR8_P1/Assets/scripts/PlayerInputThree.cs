using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInputThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0) 
            if (Input.GetKey(KeyCode.Mouse0))
            print ("Mouse X movement selected: " +  mxVal);
        if (myVal != 0) 
            if (Input.GetKey(KeyCode.Mouse0))
            print("Mouse Y movement selected: " + myVal);
    }
}
