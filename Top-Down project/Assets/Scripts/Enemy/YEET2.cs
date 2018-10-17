using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YEET2 : MonoBehaviour {
    public GameObject Bullet;
    public float ShootDistance;

    public GameObject Player;
    public float bulletSpeed = 5;
    public float timeBetweenShots = 3;

    Vector3 ShootDirection;

    float Shottimer = 0;

    void Update () {

        Shottimer += Time.deltaTime;

        ShootDirection = Player.transform.position - transform.position;
        if (Shottimer >= timeBetweenShots && ShootDirection.magnitude < ShootDistance)
        {

            Shottimer = 0;

            ShootDirection = Player.transform.position - transform.position;

            ShootDirection.Normalize();

            GameObject bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * ShootDirection;

            Destroy(bullet, 10f);


        }


    }

    
}
