using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script moves the object touching the object this script is attached to, usually the player touching a meanie

public class MeanieMovesPlayer : MonoBehaviour
{
    public GameObject thePlayer; //this is the player

    void OnTriggerEnter2D(Collider2D collider) //when something (usually the player) touches this object
    {
        thePlayer.transform.position = new Vector3(0.0f, 0.0f, 0.0f); //move the player to the start of the game (0,0,0 is the start of every level)
        
    }

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.Find("Player"); //define thePlayer as the Player gameObject

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}