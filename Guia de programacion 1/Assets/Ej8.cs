using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej8 : MonoBehaviour
{
    public int num1;

    void Start()
    {
        string[] diasSemana = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };

        if (num1 >= 1 && num1 <= diasSemana.Length)
        {
            Debug.Log("El día correspondiente es: " + diasSemana[num1 - 1]);
        }
        else
        {
            Debug.Log("El día ingresado no es válido");
        }
    }
}
