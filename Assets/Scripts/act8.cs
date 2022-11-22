using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act8 : MonoBehaviour
{
    public int puntos;


    private void Start()
    {
        if (puntos > 100)
        {
            Debug.Log($"Tienes mas de 100 puntos");
        }
        else if (puntos <= 100 && puntos > 75)
        {
            Debug.Log($"Tienes mas de 75 puntos pero menos o igual a 100");
        }
        else if (puntos <= 75 && puntos > 50)
        {
            Debug.Log($"Tienes más de 50 puntos, pero menos o igual a 75");
        }
        else if (puntos <= 50 && puntos > 25)
        {
            Debug.Log($"Tienes más de 25 puntos, pero menos o igual a 50");
        }
        else
        {
            Debug.Log($"Tienes menos o igual a 25 puntos");
        }
    }
}
