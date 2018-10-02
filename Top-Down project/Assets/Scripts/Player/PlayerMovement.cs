using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //allows the user to deside individual speed values for horizontal and vertical movements
    public float HSpeed;
    public float VSpeed;

    

    float x;
    float y;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");

        if (x >= 0.5)
        {
           
            transform.Rotate(0f, 0f, 5f);
        }else if (x <= -0.5)
        {

            transform.Rotate(0f, 0f, -5f);
        }

        if (y == 1)
        {
            // GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 5f);
            add force;
        }
    }

}
