using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectirEnemy : MonoBehaviour {

    public GameObject bala;
    public Transform tag;
    public float tasa;
    private float time;
    

    // Use this for initialization


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > time)
        {
            time = Time.time + tasa;
            Instantiate(bala, tag.position, tag.rotation);
        }
      
    }
}
