using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarcontraseña : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
    public Text textmsj;
    public Text ingresousuario;
    public GameObject cartelitomsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void validarContrasenia() {
        contraseñausuario = ingresousuario.text;
        if (contraseñausuario==contraseñacorrecta)
        {
            cartelitomsj.SetActive(true);
            textmsj.text = "Bienvenido/a";
            Debug.Log("Bienvenido/a");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textmsj.text = "La contraseña es incorrecta";
            Debug.Log("La contraseña es incorrecta");
        }
}
}
