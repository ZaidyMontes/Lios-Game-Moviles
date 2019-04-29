using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    public float velocidad = -10f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void moverIzquierda()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        transform.eulerAngles = new Vector2(0, 0);
    }

    public void moverDerecha()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
        transform.eulerAngles = new Vector2(0, 180);
    }



  // Jugador se destruye al morir
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Destroid" || col.gameObject.tag == "Enemigo")
        {
            //;Destroy(gameObject);
            SceneManager.LoadScene("escena1");


        }

        if (col.gameObject.tag == "Final")
        {
            SceneManager.LoadScene("MenuInicio");
        }
        
    }





}
    




