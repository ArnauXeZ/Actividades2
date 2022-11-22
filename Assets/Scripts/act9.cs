using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act9 : MonoBehaviour
{
    public bool wantsVegetarianOption;
    
    private void Start()
    {
        if (wantsVegetarianOption == true)
        {
            Debug.Log($"Opción no vegetariana próximamente");
        }
        else
        {
            Debug.Log($"Opción vegetariana próximamente");
        }
    }
}
