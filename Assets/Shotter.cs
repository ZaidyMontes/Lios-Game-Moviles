using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotter : MonoBehaviour {

    public Transform shotSpawn;
    public GameObject shot;

    // Use this for initialization
    void Start () {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
