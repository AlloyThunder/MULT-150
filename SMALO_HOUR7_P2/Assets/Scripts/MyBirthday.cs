using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float April = 1f;
        while (April<=30)
        {
            if (April==13)
            {
                Debug.Log("It's my birthday!");
            }
            else
            {
                Debug.Log(April);
            }
            April++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
