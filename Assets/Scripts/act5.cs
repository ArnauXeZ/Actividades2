using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act5 : MonoBehaviour
{
    public int edad;
    
    private void Start()
    {
        if (edad >= 18)
        {
            Debug.Log($"Hola tienes {edad} años, eres mayor de edad");
        }

        else
        {
            Debug.Log($"Hola tienes {edad} años, NO eres mayor de edad");
        }
    }
}
