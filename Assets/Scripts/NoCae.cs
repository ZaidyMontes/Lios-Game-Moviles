using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoCae : MonoBehaviour {

    public Sensor sensorIzq;
    public Sensor sensorDer;

    private Enemigo enemigo;

	// Use this for initialization
	void Start () {
        enemigo = GetComponent<Enemigo>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("izq: "+sensorIzq.activo+" - der: "+sensorDer.activo);
        if (!sensorIzq.activo) {
            enemigo.rapidez = Mathf.Abs(enemigo.rapidez);
        }else if (!sensorDer.activo) {
            enemigo.rapidez = -Mathf.Abs(enemigo.rapidez);
        }

    }
}
