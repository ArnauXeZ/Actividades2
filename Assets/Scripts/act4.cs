using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act4 : MonoBehaviour
{
    public float basee;
    public float altura;
    private float triangulo;

    
    private void Start()
    {
        if (basee > 0 && altura > 0)
        {
            triangulo = basee * altura / 2;
            Debug.Log($"La area del triangulo es {triangulo}");
        }
        else 
        {
            Debug.Log($"La area no se pudo calcular");
        }

    }
}

