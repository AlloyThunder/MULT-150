using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log ("You've entered " + gameObject.name + ".");
    }
    void OnTriggerStay(Collider other)
    {
        Debug.Log ("You're still in" + gameObject.name + ".");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log ("You've left " + gameObject.name + ".");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
