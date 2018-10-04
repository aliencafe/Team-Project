using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //varible for storing player Y
    Vector3 PlayerY;
    
    //Grabs the player for caculations
    public GameObject player;
    public GameObject myGameObject;
   
   
    // Update is called once per frame
    void Update ()
    {
        PlayerY = player.gameObject.transform.position;
   
        transform.position = new Vector3(PlayerY.x, PlayerY.y, myGameObject.transform.position.z);
       
     
        






    }
}
