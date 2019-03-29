using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public Transform objetivo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(objetivo)
        {
            Vector3 posicion = transform.position;
            posicion.x = objetivo.position.x;
            transform.position = posicion;
        }
		
	}
}
