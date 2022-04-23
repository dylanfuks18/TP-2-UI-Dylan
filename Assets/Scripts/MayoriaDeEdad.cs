using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MayoriaDeEdad : MonoBehaviour
{
    public int edadusuario;
    public Text MiTexto;
    void Start()
    {
        if (edadusuario >= 18)
        {
            MiTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        }
        else
        {
            MiTexto.text = "No es mayor de edad";
            Debug.Log(" No es mayor de edad");
        }
    }

}
