using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //allows the user to deside individual speed values for horizontal and vertical movements
    public float HSpeed;
    public float VSpeed;

    public float MaxHSpeed;
    public float MaxVSpeed;

    float x1;
    float x2;
    float y2;

    // Use this for initialization
    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Child's Tag")
            return; // do nothing
        Debug.Log("parent goes ouch!");
    }

    // Update is called once per frame
    void Update()
    {

        x1 = Input.GetAxisRaw("Horizontal");
        x2 = Input.GetAxis("Horizontal2");
        y2 = Input.GetAxis("Vertical2");

        if (x1 >= 0.5)
        {
           
            transform.Rotate(0f, 0f, -2f);
        }else if (x1 <= -0.5)
        {

            transform.Rotate(0f, 0f, 2f);
        }

        if (GetComponent<Rigidbody2D>().velocity.x > MaxHSpeed)
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(MaxHSpeed, GetComponent<Rigidbody2D>().velocity.y);

        } else if (GetComponent<Rigidbody2D>().velocity.x < -MaxHSpeed)

        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-MaxHSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        else if (x2 != 0)
        {
            float speed = x2 * HSpeed;

            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);

        }else if (x2 == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x / 1.3f, GetComponent<Rigidbody2D>().velocity.y);
        }


         if (GetComponent<Rigidbody2D>().velocity.y > MaxVSpeed)
        {

            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, MaxVSpeed);

        }

        else if (GetComponent<Rigidbody2D>().velocity.y < -MaxVSpeed)

        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -MaxVSpeed);
        }

        else if(y2 != 0)
        {
            float speed = y2 * VSpeed;

            GetComponent<Rigidbody2D>().velocity = (new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed));
           
        }
        else if (y2 == 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y / 1.3f);
        }
    }

}
