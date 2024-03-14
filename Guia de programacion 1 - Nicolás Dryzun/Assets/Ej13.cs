using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej13 : MonoBehaviour
{
    float SALARIO_HORA_NORMAL = 16f;
    float SALARIO_HORA_EXTRA = 20f;
    public int horasTrabajadas;
    // Start is called before the first frame update
    void Start()
    {
        float salarioSemanal;

        if (horasTrabajadas <= 40)
        {
            salarioSemanal = horasTrabajadas * SALARIO_HORA_NORMAL;
        }
        else
        {
            int horasNormales = 40;
            int horasExtras = horasTrabajadas - horasNormales;
            salarioSemanal = horasNormales * SALARIO_HORA_NORMAL + horasExtras * SALARIO_HORA_EXTRA;
        }

        Debug.Log("El salario semanal del obrero es: $" + salarioSemanal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
