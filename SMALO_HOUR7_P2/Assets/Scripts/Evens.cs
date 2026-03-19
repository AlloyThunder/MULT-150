using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float number = 22f;
        Debug.Log(number);
        while (number < 100)
        {
            number++;
            number++;
            Debug.Log(number);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
