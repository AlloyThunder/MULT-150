using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        int healthpoints = 3992;
        healthpoints = Usepotion(healthpoints);
        healthpoints = Usepotion(healthpoints);
        healthpoints = Usepotion(healthpoints);
        healthpoints = Usepotion(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Usepotion(int health)
    {
        health += 400;
        Debug.Log(health);
        return health;
    }
}
