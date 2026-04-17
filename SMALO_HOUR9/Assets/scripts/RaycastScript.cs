using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        //opposite because we rotate about those axes
        transform.Rotate(dirY, -dirX, 0);
        CheckForRaycastHit();
        
        void CheckForRaycastHit()
        {
            RaycastHit Hit;
            if (Physics.Raycast(transform.position, transform.forward, out Hit))
            {
                print(Hit.collider.gameObject.name + " destroyed!");
                Destroy(Hit.collider.gameObject);
            }
        }
    }
}
