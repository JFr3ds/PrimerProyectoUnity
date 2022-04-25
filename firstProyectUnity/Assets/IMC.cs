using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IMC : MonoBehaviour
{
    public string nombreUsuario;
    public float altura;
    public float peso;
    public float imc = 0;

    // Start is called before the first frame update
    void Start()
    {
        imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Debug.Log("El usuario: " + nombreUsuario + " esta muy bajo de peso");
        }

        if (imc > 18.5 && imc <= 24.9)
        {
            Debug.Log("El usuario: " + nombreUsuario + " su peso es normal");
        }

        if (imc > 24.9 && imc <= 29.9)
        {
            Debug.Log("El usuario: " + nombreUsuario + " su peso esta por encima de lo normal");
        }

        if (imc >= 30)
        {
            Debug.Log("El usuario: " + nombreUsuario + " Tiene Obesidad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
