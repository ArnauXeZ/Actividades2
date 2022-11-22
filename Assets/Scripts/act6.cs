using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act6 : MonoBehaviour
{
    public float distanciaRecorrida;
    public float distanciaTotal;
    public float operacion;

    
    private void Start()
    {
        if (distanciaRecorrida >= distanciaTotal)
        {
            Debug.Log($"Enhorabuena, as recorrido todo el trayecto");
        }
        else
        {
            operacion = distanciaTotal - distanciaRecorrida;
            Debug.Log($"Animo te queda {operacion} pasos para terminar el trayecto tu puedes");
        }
    }
}
