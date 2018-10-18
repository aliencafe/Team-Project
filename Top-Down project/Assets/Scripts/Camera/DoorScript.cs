using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    public GameObject Player;
    public GameObject door;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject == Player)
        {
            door.SetActive(true);
        }
    }



}
