using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public bool isReady = false;
    public int bumps = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Chaos")
        {
            bumps += 1;
            Debug.Log("You've hit " + gameObject.name + " " + bumps + " time(s)!");
            if (bumps >= 3)
            {
                isReady = true;
                Debug.Log(gameObject.name + " is ready!");
            }
        }
    }
}
