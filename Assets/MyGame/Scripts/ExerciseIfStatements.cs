using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatements : MonoBehaviour
{
    public bool condition;

    // Start is called before the first frame update
    void Start()
    {
        if (condition) 
        {
            Debug.Log("Diese Aussage stimmt!");
        }
        else 
        {
            Debug.Log("Diese Condition ist falsch!");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
