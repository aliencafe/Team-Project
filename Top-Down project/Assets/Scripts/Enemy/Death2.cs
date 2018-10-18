using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death2 : MonoBehaviour {

    public int Health = 5;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")

        {

            Health = Health - 1;
            Destroy(collision.gameObject);
            Debug.Log("I'm at " + Health);
            if (Health <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
