using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEnemy : MonoBehaviour {

    public float speed;
    private Rigidbody2D rig;
    public Vector3 direction;
    public float reloj = 0;
    public GameObject objeto;


    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    /*void Start()
    {
        rig.velocity = transform.right * speed;
    }*/

    // Update is called once per frame
    void Update()
    {
        rig.velocity = direction.normalized * speed;


        reloj -= Time.deltaTime;
        if (reloj <= 0)
        {
            objeto.SetActive(false);
        }

    }
    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Destroid")
        {
            Destroy(gameObject);

        }
    }*/
}
