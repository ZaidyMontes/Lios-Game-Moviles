using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

        public int lives = 6;
   
    // Use this for initialization
    void Start () {
       

	}
	
	// Update is called once per frame
	void Update () {
       
        

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.gameObject.tag == "Bala" )

        {
            lives--;
            if(lives <= 0)
            {
                Destroy(gameObject);
            }
        }

 
    }
}
