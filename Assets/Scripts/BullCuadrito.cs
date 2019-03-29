using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCuadrito : MonoBehaviour {

    public GameObject shot3;
    public Transform punto3;
    public float tasa3;
    private float time3;
    private float contador3;
    // Use this for initialization


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        contador3 += Time.deltaTime;

        if (contador3 > time3)
        {
            time3 = Time.time + tasa3;
            Instantiate(shot3, punto3.position, punto3.rotation);
        }
    }
}
