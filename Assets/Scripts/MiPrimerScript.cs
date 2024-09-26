using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class MiPrimerScript : MonoBehaviour
{
    //Variables
    // EL tipo de Dato........Nombre
    int numeroDeSaltos;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int tercerLogroSaltos = 27;
    // Start is called before the first frame update
    void Start()
    {
        numeroDeSaltos = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision infoChoque)
    {
        numeroDeSaltos = numeroDeSaltos + 1;
        Debug.Log("Veces que ha chocado: " + numeroDeSaltos + " " + gameObject.name + " He chocado con " + infoChoque.gameObject.name);

        //Versión mejorada, refinada y corta de los siguientes if y else if, || se comsidera como "o" en estos casos, para un "y", en el que se deben cumplir dos o más requisitos se usa &
        /*if (numeroDeSaltos == primerLogroSaltos || numeroDeSaltos == segundoLogroSaltos || numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log(gameObject.name + "He saltado " + numeroDeSaltos + " veces, ¿a que soy increíble?");
        }*/

        /*if (numeroDeSaltos == primerLogroSaltos)
        {
            Debug.Log("He chocado " + numeroDeSaltos + " veces :P " + gameObject.name);
        }
        else if (numeroDeSaltos == segundoLogroSaltos)
        {
            Debug.Log("He chocado solo " + numeroDeSaltos + " veces ;_; " + gameObject.name);
        }
        else (numeroDeSaltos == tercerLogroSaltos)
        {
            Debug.Log("Los simpson no son tan buenos como antaño, keh berwenzha, ¿verdad, " + gameObject.name + "? Solo he logrado " + numeroDeSaltos);
        }*/
        //Igual == ; Distinto != ; Mayor x>10 ; Menor x<10 ; Mayo o igual >= ; Menor o igual <= ; o' || ; y &&
    }
}
