using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseIfStatements : MonoBehaviour
{
    public bool condition;
    public string text;
    public string text2;
    

    // Start is called before the first frame update
    void Start()
    {
        if (condition) 
        {
           // Debug.Log("Diese Aussage stimmt!");
        }
        else 
        {
          //  Debug.Log("Diese Condition ist falsch!");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        // if statement float
        if (Random.Range(5f,15f)>10)
        {
           // Debug.Log("Wert ist ueber 10!");
        }
        else
        {
           // Debug.Log("Wert ist unter 10!");
        }



        // if statement string
        if (text == text2)
        {
            // Debug.Log("Text entspricht Text2!");
        }
        else
        {
            // Debug.Log("Text entspricht nicht Text2!");
        }


        // if statement mit mehreren konditionen
        if (text == text2 && condition && 10 > 3 && true)
        {
           // Debug.Log("beide konditionen sind erfuellt");
        }
        else
        {
           // Debug.Log("nicht beide konditionen sind erfuellt");
        }


        // if statement mit oder
        if (text == text2 || condition)
        {
           // Debug.Log("Eine der beiden kondition ist true");
        }


        // if statement verschachtelt
        if (text == text2)
        {
            if (condition)
            {
                Debug.Log("beide kond sind wahr");
            }
            else
            {
                Debug.Log("nur die aeußerste ist wahr");
            }
        }
    }
}
