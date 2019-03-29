using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{

    public string capa = "Ground";
    public float distancia = 0.1f;

    public bool activo;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            -Vector2.up, distancia,
            LayerMask.GetMask(capa)
            );
        activo = hit.collider != null;
       
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, -Vector2.up * distancia);
    }
}
