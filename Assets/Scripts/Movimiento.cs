using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    private int contador = 0;
    public Movimiento movimiento;
    public enum GameState { Idle, Playing };
    public GameState gameState = GameState.Idle;
    //public Vector3 velocidad;
    public float rapidez;
    public float salto;
    // public float velocidadup;

    private Animator animator;
    private Rigidbody2D rigidbody;
    private Sensor sensor;
    private SpriteRenderer sprite;
    private bool mirar;
    public GameObject canvas;
    public GameObject shot;
    public Transform punto;
    public GameObject jugador;
    public Transform puntoInicio;


    /*public GameObject shot;
    public Transform Punto;*/



    // public Transform  

    // Use this for initialization
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        sensor = GetComponentInChildren<Sensor>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        this.mirar = true;
    }

    // Update is called once per frame
    void Update()
    {
       

   


        float horizontal = Input.GetAxis("Horizontal");
        
        Vector3 velocidad = rigidbody.velocity;
        velocidad.x = horizontal * rapidez;
         

        if (Input.GetButtonDown("Jump") && sensor.activo)
        { //si presiono la tecla de salto y está sobre el suelo
          //cambio la velocidad en y
            velocidad.y = salto;
        }

        

        rigidbody.velocity = velocidad;
        //} else {
        //transform.position = new Vector3(-8, 0, 0);
        //}

        //flip

        if ((velocidad.x < 0) && (this.mirar))
        {
            this.Flip();

            this.mirar = false;
        }
        else if ((velocidad.x > 0) && (!this.mirar))
        {
            this.Flip();
            this.mirar = true;
        }

        animator.SetFloat("Rapidez", Mathf.Abs(velocidad.x));
        animator.SetBool("Suelo", sensor.activo);
        /*if (velocidad.x < 0)
         {
             Bala variable = GetComponent<Bala>()
                 {
                 Bala speed = 10f;
             }
         }*/




        // animator

        /*if (Input.GetButton("Fire1"))
        {
            Instantiate(shot, Punto.position, Punto.rotation);
        }*/


    }

    void Flip()
    {
        this.transform.Rotate(Vector3.up, 180);
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
    




