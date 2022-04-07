using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    public float precio1;
    public float precio2;
    public float precio3;
    public float monto;
    // Start is called before the first frame update
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. Comunicar si la suma de los mismos supera o no el monto de dinero disponible. Luego indicar cuánto dinero sobra o falta.
    void Start()
    {
        float preciosumado;
        float resto;
        float faltante;
        preciosumado = precio1 + precio2 + precio3;
        resto = monto - preciosumado;
        faltante = preciosumado - monto;

        if (preciosumado>monto)
        {
            Debug.Log("El monto es superado");
            Debug.Log("Faltan " + faltante + " pesos");
        }

        else if (preciosumado<monto)
        {
            Debug.Log("El monto no es superado");
            Debug.Log("Sobran " + resto + " pesos");
        }

        else
        {
            Debug.Log("el monto y el precio son iguales asi que no sobra ni falta dinero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
