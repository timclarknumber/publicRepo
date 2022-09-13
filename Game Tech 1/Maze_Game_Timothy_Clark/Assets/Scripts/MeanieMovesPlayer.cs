using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script moves the object touching the object this script is attached to, usually the player touching a meanie

public class MeanieMovesPlayer : MonoBehaviour
{
    public CurrentCheckpoint currentCheckpoint;
    public GameObject checkpointManager;
    public GameObject thePlayer; //this is the player
    public Vector2 playerPlace = new Vector2(0.0f, 0.0f);

    void OnTriggerEnter2D(Collider2D collider) //when something (usually the player) touches this object
    {
        thePlayer.transform.position = playerPlace; //move the player to the start of the game (0,0,0 is the start of every level)
        
    }

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = GameObject.Find("Player"); //define thePlayer as the Player gameObject
        checkpointManager = GameObject.Find("CheckpointManager");
        currentCheckpoint = checkpointManager.GetComponent<CurrentCheckpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPlace = currentCheckpoint.currentPosForCheck;
    }
}