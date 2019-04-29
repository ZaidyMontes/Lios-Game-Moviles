using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonDerecho : MonoBehaviour
{
    private Personaje personaje;
    private CircleCollider2D presionar;

    // Use this for initialization
    void Start()
    {
        presionar = GetComponent < CircleCollider2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        tocandoPantalla();
    }

    private void tocandoPantalla()
    {
        int numPresiones = 0;
        foreach (Touch toque in Input.touches)
        {
            if (toque.phase != TouchPhase.Ended && toque.phase != TouchPhase.Canceled)
                numPresiones++;
        }
        if (numPresiones > 0 | Input.GetMouseButtonDown(0)) {
            //Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector3 posicionTap = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 posicionTap2D = new Vector2(posicionTap.x, posicionTap.y);
            bool presiono = presionar.OverlapPoint(posicionTap2D);
            if (presiono)
            {
                personaje = this.transform.parent.gameObject.GetComponent <Personaje> ();
                personaje.MoverJugadorDerecha();
            }
        }
    }
}
