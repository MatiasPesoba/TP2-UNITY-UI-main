using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MayoríadeEdad : MonoBehaviour
{
    public int edadusuario;
    public Text mitexto;
    void Start()
    {
        if (edadusuario >= 18)
        {
            Debug.Log("Usted es mayor de edad");
            mitexto.text = "Usted es mayor de edad";
        }
        else
        {
            Debug.Log("Usted no es mayor de edad");
            mitexto.text = "Usted no es mayor de edad";

        }
    }
}
