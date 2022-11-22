using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act7 : MonoBehaviour
{
    public string calculadora;
    public float numero1;
    public float numero2;
    private float resultado;

    
    private void Start()
    {
        if (calculadora == "suma")
        {
            resultado = numero1 + numero2;
            Debug.Log($"{numero1} + {numero2} = {resultado}");
        }
        else if (calculadora == "resta")
        {
            resultado = numero1 - numero2;
            Debug.Log($"{numero1} - {numero2} = {resultado}");
        }
        else if (calculadora == "multiplicacion")
        {
            resultado = numero1 * numero2;
            Debug.Log($"{numero1} * {numero2} = {resultado}");
        }
        else if (calculadora == "division")
        {
            resultado = numero1 / numero2;
            Debug.Log($"{numero1} / {numero2} = {resultado}");
        }
    }
}
