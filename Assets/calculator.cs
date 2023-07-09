using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

 public class calculator : MonoBehaviour
{


    [SerializeField] private InputField inputFieldFirst ;
    [SerializeField] private InputField inputFieldSecond;
    [SerializeField] private Text result;




    public void onPress1()
    {
        

        int a = int.Parse(inputFieldFirst.text);

        int b = int.Parse(inputFieldSecond.text);


        int z = a + b;
        result.text = z.ToString();

        
    }
    public void onPress2()
    {
        int a = int.Parse(inputFieldFirst.text);

        int b = int.Parse(inputFieldSecond.text);


        int v = a - b;
        result.text = v.ToString();
    }
    public void onPress3()
    {
        int a = int.Parse(inputFieldFirst.text);

        int b = int.Parse(inputFieldSecond.text);


        int x = a * b;
        result.text = x.ToString();
    }
    public void onPress4()
    {
        int a = int.Parse(inputFieldFirst.text);

        int b = int.Parse(inputFieldSecond.text);


        int y = a / b;
        result.text = y.ToString();
    }
}
    


