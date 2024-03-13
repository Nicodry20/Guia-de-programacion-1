using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejif : MonoBehaviour
{
    public int edad;

    // Start is called before the first frame update
    void Start()
    {
        if (edad < 0)
        {
            Debug.Log("edad no puede ser negativa");
        }
        else if (edad > 18)
        {
            Debug.Log("Usted es mayor de edad");

        }
        else
        {
            Debug.Log("Usted es menor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}