using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField clave;
    string contraIngresada;
    string confirmacion;
    string contra;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Confirmar()
    {
        //obtener el nombre del inputfield
        contra = "Yuse7";
        contraIngresada = clave.text;

        //concatenar el nombre con un saludo
        if (contraIngresada == contra)
        {
            confirmacion = "Clave correcta";
        }
        else
        {
            confirmacion = "Clave incorrecta";
        }
        //mostrar el saludo en txtSaludo

        txtResultado.text = confirmacion;
    }
}
