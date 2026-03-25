using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light alight;
    public float intensity;
    
    // Start is called before the first frame update
    void Start()
    {
        alight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (alight.intensity == 0)
            {
                alight.intensity = 10;
            }
            else 
            { 
                alight.intensity = 0;
            }
            
        }
    }
}
