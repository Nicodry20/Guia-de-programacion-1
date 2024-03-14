using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Ej4 : MonoBehaviour
{
    public int num1;
    public int num2;
    int suma;

    void Start()
    {
        suma = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + suma);
    }

    void Update()
    {

    }
}