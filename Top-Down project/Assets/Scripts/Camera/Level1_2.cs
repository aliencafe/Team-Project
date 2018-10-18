using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1_2 : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)

            SceneManager.LoadScene("Level2");

    }

}

