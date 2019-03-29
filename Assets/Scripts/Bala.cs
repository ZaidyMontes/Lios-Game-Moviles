using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rig;
    // private float damage;
    public float reloj2 = 0;
    public GameObject objeto2;



    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        rig.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        reloj2 -= Time.deltaTime;
        if (reloj2 <= 0)
        {
            objeto2.SetActive(false);
        }

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemigo" || col.gameObject.tag == "Destroid")
        {
            //damage = GetComponent<Camara>();

            Destroy(gameObject);

        }
    }

}
