using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletSpeed : MonoBehaviour {


    public Rigidbody2D rigidbody;
    public float maxSpeed = 200;

    float timer;

    bool Tag = false;

	
	// Update is called once per frame
	void Update () {

        if(Tag == false)
        {
            timer += Time.deltaTime;
        } 
        
        if(timer >= 0.05f)
        {
            gameObject.tag = "Bullet";
            Tag = false;
        }

        if (rigidbody.velocity.magnitude > maxSpeed)
        {
            rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.gameObject.tag != "Reflector")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
