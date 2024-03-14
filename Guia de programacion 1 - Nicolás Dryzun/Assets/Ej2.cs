using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    int num1 = 4;
    int num2 = 5;
    int suma;
    int producto;
    // Start is called before the first frame update
    void Start()
    {
        suma = num1 + num2;
        Debug.Log("La suma entre " + num1 + " y " + num2 + " es " + suma);
        

        producto = num1 * num2;
        Debug.Log("El producto entre " + num1 + " y " + num2 + " es " + producto);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}