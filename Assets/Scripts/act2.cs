using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class act2 : MonoBehaviour
{
    public int mes;
    private int horoscope;
        //esto de los horoscopos me lia mazo la cabeza no entiendo los de españa los de china ya ni te digo
        //lo he puesto con los meses del 1 al 12 y dependiendo del numero osea del mes eres un Horoscopo o otro
    private void Start()
    {
        horoscope = mes % 12;

        if (horoscope == 1)
        {
            Debug.Log($"Tu horoscopo es Aries ");
        }
        else if (horoscope == 2)
        {
            Debug.Log($"Tu horoscopo es Tauro ");
        }
        else if (horoscope == 3)
        {
            Debug.Log($"Tu horoscopo es Geminis ");
        }
        else if (horoscope == 4)
        {
            Debug.Log($"Tu horoscopo es Cancer ");
        }
        else if (horoscope == 5)
        {
            Debug.Log($"Tu horoscopo es Leo ");
        }
        else if (horoscope == 6)
        {
            Debug.Log($"Tu horoscopo es Virgo ");
        }
        else if (horoscope == 7)
        {
            Debug.Log($"Tu horoscopo es Libra");
        }
        else if (horoscope == 8)
        {
            Debug.Log($"Tu horoscopo es Escorpio");
        }
        else if (horoscope == 9)
        {
            Debug.Log($"Tu horoscopo es Sagitario ");
        }
        else if (horoscope == 10)
        {
            Debug.Log($"Tu horoscopo es Capricornio ");
        }
        else if (horoscope == 11)
        {
            Debug.Log($"Tu horoscopo es Acuario ");
        }
        else if (horoscope == 12)
        {
            Debug.Log($"Tu horoscopo es Piscis ");
        }
    }
}
