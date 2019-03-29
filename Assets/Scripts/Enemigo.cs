using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

    public float rapidez = -2f;

    private Rigidbody2D rigidbody;
    private SpriteRenderer sprite;
    // Use this for initialization
    void Start() {
        rigidbody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        Vector2 velocidad = rigidbody.velocity;
        velocidad.x = rapidez;
        rigidbody.velocity = velocidad;
        if (rapidez < 0)
        {
            sprite.flipX = false;
        } else if (rapidez > 0)
        {
            sprite.flipX = true;
        }
     
    }
   void OnTriggerEnter2D(Collider2D col)
    { 
         if (col.gameObject.tag == "Destroid" || col.gameObject.tag == "Bala")
         { 
                Destroy(gameObject);
            
          }
    }

   

}


