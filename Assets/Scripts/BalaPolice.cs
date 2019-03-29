using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPolice : MonoBehaviour {


    public float speed2;
    private Rigidbody2D rig2;
    // private float damage;
    public float reloj2 = 0;
    public GameObject objeto2;


    private void Awake()
    {
        rig2 = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        rig2.velocity = transform.right * speed2;
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
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Destroid")
        {
            Destroy(gameObject);

        }
    }
}
