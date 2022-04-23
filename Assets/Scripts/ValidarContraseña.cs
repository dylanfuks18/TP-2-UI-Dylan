using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ValidarContraseña : MonoBehaviour
{

    string contraseñacorrecta;
    string ContraseñaUsuario;
    public Text IngresoUsuario;
    public Text textomsj;
    public GameObject cartelitomsj;
    void Start()
    {
        contraseñacorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarcontraseña()
    {
        ContraseñaUsuario = IngresoUsuario.text;
        if (ContraseñaUsuario == contraseñacorrecta)
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }


}
