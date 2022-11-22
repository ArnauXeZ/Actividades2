using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act10 : MonoBehaviour
{
    public int año;
    
    private void Start()
    {
        if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
        {
            Debug.Log($"{año} es un año bisiesto");
        }
        else
        {
            Debug.Log($"{año} no es un año bisiesto");
        }
    }
}
