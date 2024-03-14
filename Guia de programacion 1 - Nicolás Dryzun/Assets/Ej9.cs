using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9 : MonoBehaviour
{
    public string nombrePersona1;
    public string nombrePersona2;
    public string nombrePersona3;
    public float capitalPersona1;
    public float capitalPersona2;
    public float capitalPersona3;
    // Start is called before the first frame update
    void Start()
    {
        float totalAportado = capitalPersona1 + capitalPersona2 + capitalPersona3;
        float porcentajePersona1 = capitalPersona1 / totalAportado * 100;
        float porcentajePersona2 = capitalPersona2 / totalAportado * 100;
        float porcentajePersona3 = capitalPersona3 / totalAportado * 100;


        Debug.Log(nombrePersona1 + " capital aportado: " + capitalPersona1 + ". Porcentaje del capital: %" + porcentajePersona1);
        Debug.Log(nombrePersona2 + " capital aportado: " + capitalPersona2 + ". Porcentaje del capital: %" + porcentajePersona2);
        Debug.Log(nombrePersona3 + " capital aportado: " + capitalPersona3 + ". Porcentaje del capital: %" + porcentajePersona3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
