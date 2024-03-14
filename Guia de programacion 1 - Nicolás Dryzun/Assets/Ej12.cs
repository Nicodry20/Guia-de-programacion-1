using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej12 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int dado1 = Random.Range(1,7);
        int dado2 = Random.Range(1,7);
        int dado3 = Random.Range(1,7);

        Debug.Log("Dado1: " + dado1);
        Debug.Log("Dado2: " + dado2);
        Debug.Log("Dado3: " + dado3);

        if (dado1 == 6 && dado2 == 6 && dado3 == 6)
        {
            Debug.Log("Excelente");
        }
        else if ((dado1 == 6 && dado2 == 6) || (dado1 == 6 && dado3 == 6 || dado2 == 6 && dado3 ==6))
        {
            Debug.Log("Muy bien");
        }
        else if (dado1 == 6 || dado2 == 6 || dado3 == 6)
        {
            Debug.Log("Regular");
        }
        else
        {
            Debug.Log("Insuficiente");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
