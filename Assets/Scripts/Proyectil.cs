using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour {
    public GameObject shot;
    public Transform punto;
    public float tasa;
    private float time;
   
    // Use this for initialization


    void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") && Time.time > time)
        {
            time = Time.time + tasa;
            Instantiate(shot, punto.position, punto.rotation);
        }

       
    }
}
