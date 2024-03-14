using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej14 : MonoBehaviour
{
    public char simbolo;
    public int numero1;
    public int numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (simbolo == 's')
        {
            int suma = numero1 + numero2;
            Debug.Log("La suma entre " + numero1 + " y " + numero2 + " es " + suma);
        }
        else if (simbolo == 'r')
        {
            int resta = numero1 - numero2;
            Debug.Log("La resta entre " + numero1 + " y " + numero2 + " es " + resta);
        }
        else if (simbolo == 'p')
        {
            int producto = numero1 * numero2;
            Debug.Log("El producto entre " + numero1 + " y " + numero2 + " es " + producto);
        }
        else if (simbolo == 'd')
        {
            if (numero2 != 0)
            {
                float division = (float)numero1 / numero2;
                Debug.Log("La división es: " + division);
            }
            else
            {
                Debug.Log("No se puede dividir por cero.");
            }
        }
        else
        {
            Debug.Log("Operación no válida.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
