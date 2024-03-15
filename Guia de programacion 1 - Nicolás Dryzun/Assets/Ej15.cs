using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej15 : MonoBehaviour
{
    public int numeroIngresado;
    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool noEstaEnNinguno;

    // Start is called before the first frame update
    void Start()
    {
        if (numeroIngresado >= 0 && numeroIngresado <= 9)
        {
            estaEnA = true;
        }
        else
        {
            estaEnA = false;
        }

        if (numeroIngresado % 2 != 0)
        {
            estaEnB = true;
        }
        else
        {
            estaEnB = false;
        }

        if (estaEnA && estaEnB)
        {
            estaEnAmbos = true;
        }
        else
        {
            estaEnAmbos = false;
        }

        if (!estaEnA && !estaEnB)
        {
            noEstaEnNinguno = true;
        }
        else
        {
            noEstaEnNinguno = false;
        }

        Debug.Log("Esta en A: " + estaEnA);
        Debug.Log("Esta en B: " + estaEnB);
        Debug.Log("Esta en ambos: " + estaEnAmbos);
        Debug.Log("No esta en ninguno: " + noEstaEnNinguno);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}