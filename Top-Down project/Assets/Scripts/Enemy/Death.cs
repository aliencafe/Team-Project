﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")

        {

            Debug.Log("Ooof");
            Destroy(gameObject);
            Destroy(collision.gameObject);

        }

    }
}
