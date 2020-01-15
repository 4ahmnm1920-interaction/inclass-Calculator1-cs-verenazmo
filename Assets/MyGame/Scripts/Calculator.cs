using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    public InputField number1;
    public InputField number2;
    public Button Add;
    public Button Subtract;
    public Button Divide;
    public Button Multiply;
    public Text Result;
    public Text Operator;

    // Start is called before the first frame update
    void Start()
    {
       
    }


    public void addNumbers()
    {
        string operator1 = "+";
        float Var1 = float.Parse(number1.text);
        float Var2 = float.Parse(number2.text);
        float endResult = Var1 + Var2;
        Result.text = endResult.ToString();
        Operator.text = operator1;
    }

    public void subtractNumbers()
    {
        string operator1 = "-";
        float Var1 = float.Parse(number1.text);
        float Var2 = float.Parse(number2.text);
        float endResult = Var1 - Var2;
        Result.text = endResult.ToString();
        Operator.text = operator1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
