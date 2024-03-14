using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11 : MonoBehaviour
{
    public string fechaCompra = "YYYYMMDD";
    public string nombreComprador = "Nombre del comprador";
    public string nombreProducto = "Nombre del producto";
    public int cantidad = 1;
    public float precioUnitario = 0.0f;

    void Start()
    {
        float totalPagar = cantidad * precioUnitario;

        Debug.Log("Fecha de Compra: " + fechaCompra);
        Debug.Log("Nombre del Comprador: " + nombreComprador);
        Debug.Log("Producto solicitado: " + nombreProducto);
        Debug.Log("Cantidad solicitada: " + cantidad);
        Debug.Log("Precio Unitario: $" + precioUnitario);
        Debug.Log("Total a Pagar: $" + totalPagar);
    }


    void Update()
    {

    }
}
