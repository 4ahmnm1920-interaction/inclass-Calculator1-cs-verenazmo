using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Function1();
        Function2(3, 3);
        Function3(1.4f, 3.1f);
        Function4("Cooler", "Codierer");
    }

    public void Function1() 
    {
        int number1 = 3;
        int number2 = 5;
        Debug.Log(number1 + number2);
    }

    public void Function2(int verena, int maxl)
    {
        Debug.Log(verena + maxl);
    }

    public void Function3(float var1, float var2)
    { 
    Debug.Log(var1 + var2);
    }

    public void Function4(string word1, string word2)
    {
        Debug.Log(word1 + " " + word2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
