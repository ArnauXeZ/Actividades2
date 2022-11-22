using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act1 : MonoBehaviour
{
    public float number = 0;

    private void Start()
    {
        if (number > 0)
        {
            Debug.Log($"El numero {number} es positivo");
        }
        else if (number < 0)
        {
            Debug.Log($"El numero {number} es negativo");
        }
        else 
        {
            Debug.Log($"El numero es {number} ");
        }
    }
}
