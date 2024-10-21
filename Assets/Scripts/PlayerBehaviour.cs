using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Se requiere para poder hacer uso del Text (TMP)

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float movementSpeed = 5f;
    public int monedasObtenidas;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSFX;
    public AudioClip specialCoinSFX;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        monedasObtenidas = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

        }
        Vector3 movement = new Vector3();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CoinItem"))
        {
            monedasObtenidas ++; //Esto es lo mismo que poner monedasObtenidas = monedasObtenidas + 1;
            Debug.Log("He tocado una moneda :P " + "Tengo actualmente: " + monedasObtenidas + " monedas obtenidas :D");
            AudioSource.PlayClipAtPoint(coinSFX, transform.position, 10f);
        }
        else if (other.CompareTag("CoinPower"))
        {
            monedasObtenidas += 5; //Esto es lo mismo que poner: monedasObtenidas = monedasObtenidas + 5;
            Debug.Log("#MeHeEmpoderado >:) " + "Tengo actualmente: " + monedasObtenidas + " monedas obtenidas :D");
            AudioSource.PlayClipAtPoint(specialCoinSFX, transform.position, 10f);
        }
        /*Lo mismo que el anterior, no obstante buscando por un numbre concreto en vez de un "tag", perfecto para situaciones excepcionales
        else if (other.gameObject.name == "MonedaEmpoderada")
        {
            monedasObtenidas = monedasObtenidas + 5;
            Debug.Log("#MeHeEmpoderado >:) " + "Tengo actualmente: " + monedasObtenidas + " monedas obtenidas :D");
        }*/
        if (other.tag.Contains("Coin")) //Buscará que en el tag tenga la palabra "Coin", la buscará de forma literal, por lo que mayúsculas y signos de puntuación son importantes
        {
            coinsText.text = monedasObtenidas.ToString();
            other.gameObject.SetActive(false); //Elimina el objeto al contecto, en este caso si contiene "Coin" en el tag

        }
    }
}
