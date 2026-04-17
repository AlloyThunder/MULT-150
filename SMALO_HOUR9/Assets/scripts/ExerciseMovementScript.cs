using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mS = 1;
        float mD = 20;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,mS/mD,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-mS/mD, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -mS/mD, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(mS/mD, 0, 0);
        }
    }
}
