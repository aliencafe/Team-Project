using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YEET : MonoBehaviour {
    public GameObject Bullet;
   
    public GameObject Reflector;

    public float bulletSpeed = 5;
   
	void update () {
     
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Space");
            Vector3 mousePosition = Reflector.transform.position;

            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;

            shootDir.Normalize();

            GameObject bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * shootDir;

            Destroy(bullet, 2f);


        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {



        /*if (collision.gameObject.tag == "Bullet")
        {

            Vector3 mousePosition = Reflector.transform.position;

            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;

            shootDir.Normalize();

            GameObject bullet = (GameObject)Instantiate(Bullet, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpeed * shootDir;

            Destroy(bullet, 2f);
        }*/

    }
}
