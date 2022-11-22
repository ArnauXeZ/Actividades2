using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act3 : MonoBehaviour
{
    public int number;
    private void Start()
    {
        if (number % 5 == 0)
        {
            Debug.Log($"Este numero es divisible por 5");
        }
    }
}
