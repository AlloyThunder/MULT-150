using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    public int collisons = 0;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has landed!");
        Debug.Log("the number of collisons is now " + collisons + ".");
        collisons += 1;
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
