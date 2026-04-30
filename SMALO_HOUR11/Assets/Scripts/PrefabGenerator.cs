using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    private int spawncount = 0;
    
    void Start()
    {
        
        
        while (spawncount < 10)
        {
            Vector3 spawnPosition = new Vector3(0f, 0f, (2 * spawncount));
            Instantiate<GameObject>(prefab, spawnPosition, Quaternion.identity);
            spawncount += 1;
            Debug.Log (spawncount);
        }
        
    }

    void Update()
    {
        //Whenever we hit the B key we will generate a prefab at the
        //position of the original prefab
        //Whenever we hit the space key, we will generate a prefab at the
        //position of the spawn object that this script is attahced to
        if (Input.GetKeyDown (KeyCode.B))
        {
            Instantiate(prefab);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
