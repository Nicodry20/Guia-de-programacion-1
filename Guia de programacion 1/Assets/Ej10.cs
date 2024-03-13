using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej10 : MonoBehaviour
{
    public int horaActual = 10;
    void Start()
    {
        if (horaActual >= 10 && horaActual <= 18)
        {
            Debug.Log("El estacionamiento está abierto.");
        }
        else if (horaActual < 0 || horaActual > 24)
        {
            Debug.Log("Ha ingresado una hora incorrecta");
        }
        else
        {
            Debug.Log("El estacionamiento está cerrado.");
        }
    }
}
