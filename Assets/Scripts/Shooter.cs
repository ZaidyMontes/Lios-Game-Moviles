using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public Transform bullet;
    public float time;
    public float distance;
    private float timeLeft;
    private float cosa;
    public GameObject bala;
	
	// Update is called once per frame
	void Update () {
        timeLeft = timeLeft - Time.deltaTime;
        if(timeLeft <= 0) {
            timeLeft = time;
            Shoot();
        }

        
    }

    private void Shoot() {
        Transform newBullet = Instantiate(bullet);
        newBullet.position = transform.position;
        newBullet.GetComponent<BalaEnemy>().direction = transform.forward;
       
    }
}
