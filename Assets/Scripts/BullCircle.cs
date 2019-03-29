using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCircle : MonoBehaviour
{
    public GameObject jug;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -Time.deltaTime, 0);
        transform.LookAt(jug.transform);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Destroid")
        {
            Destroy(gameObject);

        }
    }

   
	
        // transform.Translate(Vector3.right * Time.deltaTime * 4.6f);
}
