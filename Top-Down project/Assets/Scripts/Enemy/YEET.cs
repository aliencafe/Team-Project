using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YEET : MonoBehaviour {
    public GameObject Bullet;
   
   

    public float bulletSpeed = 5;
    public float timeBetweenShots = 3;
    public Vector3 ShootDirection;

    float Shottimer = 0;

    void Update () {

        Shottimer += Time.deltaTime;
        

        if (Shottimer >= timeBetweenShots)
        {

            Shottimer = 0;

            ShootDirection.Normalize();

            GameObject bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * ShootDirection;

            Destroy(bullet, 10f);


        }


    }

    
}
