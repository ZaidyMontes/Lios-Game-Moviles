using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other) {
        //Debug.Log("tag del otro: "+other.gameObject.tag);
        if(other.gameObject.tag == "Player") {
            Destroy(this.gameObject);
        }
    }


}
