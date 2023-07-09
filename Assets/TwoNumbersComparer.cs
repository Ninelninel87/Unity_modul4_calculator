using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TwoNumbersComparer : MonoBehaviour
{
    [SerializeField] public Text status;
    [SerializeField] public InputField inputField_1;
    [SerializeField] public InputField inputField_2;
    



    public void OnClick()
    {
         if(Convert.ToInt32(inputField_1.text)>(Convert.ToInt32(inputField_2.text)))
       {
         status.text = inputField_1.text;
       }
        else if (Convert.ToInt32(inputField_2.text) > (Convert.ToInt32(inputField_1.text)))
        {
            status.text = inputField_2.text;
        }
        else if (Convert.ToInt32(inputField_2.text).Equals(Convert.ToInt32(inputField_1.text)))
        {
            status.text = "Числа равны";
        }
    }
}

