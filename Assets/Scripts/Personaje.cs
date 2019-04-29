using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    // Use this for initialization
    private Movimiento[] jugadores;

    void Start()
    {
        jugadores = GetComponentsInChildren < Movimiento > ();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoverJugadorDerecha()
    {
        foreach (Movimiento jugador in jugadores)
        {
            if (jugador != null)
            {
                jugador.moverDerecha();
            }
        }
    }
    public void MoverJugadorIzquierda()
    {
        foreach (Movimiento jugador in jugadores)
        {
            if (jugador != null)
            {
                jugador.moverIzquierda();
            }
        }
    }
}

