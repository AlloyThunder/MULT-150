using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public CollisionScript bumper;
    public bool isSolved = false;
    private void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            if (bumper.isReady == true) 
            { 
                isSolved = true;
                GetComponent<Light>().enabled = false;
                Destroy(collidedWith);
            }
            
        }
    }
}
