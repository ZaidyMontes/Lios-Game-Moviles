using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour
{
    
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
   

    /*public GameObject shot;
    public Transform Punto;*/

    

   // public Transform  

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
        sensor = GetComponentInChildren<Sensor>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        this.mirar = true;
    }

    // Update is called once per frame
    void Update()
    {
        /* if (gameState == GameState.Idle && Input.GetMouseButtonDown(0))
        {
            gameState = GameState.Playing;
           canvas.SetActive(false);
        }
        else if (gameState == GameState.Playing)
        {
            Cosa();

        }*/
    
    
    

        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");
        //if (transform.position.x < 8) {
        //transform.position = transform.position + new Vector3(horizontal,vertical,0) * rapidez * Time.deltaTime;
        Vector3 velocidad = rigidbody.velocity;
        velocidad.x = horizontal * rapidez;
        if (Input.GetButtonDown("Jump") && sensor.activo)
        { //si presiono la tecla de salto y está sobre el suelo
          //cambio la velocidad en y
            velocidad.y = salto;
        }

        /*if (!sensor.activo)
        {
            velocidad.x = velocidad.x * 0.5f;
        }*/

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
            if (col.gameObject.tag == "Destroid" || col.gameObject.tag == "BalaEnemy" || col.gameObject.tag == "Enemigo" || col.gameObject.tag == "Final")
            {
            //Destroy(gameObject);

            SceneManager.LoadScene("MenuInicio");
            }
            else if (col.gameObject.tag == "Final1")
           {
            Instantiate(shot, punto.position, punto.rotation);
        }
         
        }
    



}
