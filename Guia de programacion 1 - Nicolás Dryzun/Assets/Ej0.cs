using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej0 : MonoBehaviour
{
    int edad = 16;
    float altura = 1.71f;
    string nombre = "Nicolás";
    bool estaSoltero = true;

    void Start()
    {
        Debug.Log("mi edad es " + edad);
        Debug.Log("mi altura es " + altura);
        Debug.Log("mi nombre es " + nombre);
        Debug.Log("estoy soltero? " + estaSoltero);
    }

    // Update is called once per frame
    void Update()
    {

    }
}