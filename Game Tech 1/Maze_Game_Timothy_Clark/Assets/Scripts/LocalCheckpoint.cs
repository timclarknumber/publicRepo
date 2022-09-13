using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalCheckpoint : MonoBehaviour
{
    public Vector2 localCheckPos = new Vector2(0.0f, 0.0f);
    public GameObject checkpointManager;
    public CurrentCheckpoint currentCheckpoint;
    // Start is called before the first frame update
    void Start()
    {
        localCheckPos.x = this.transform.position.x;
        localCheckPos.y = this.transform.position.y;
        checkpointManager = GameObject.Find("CheckpointManager");
        currentCheckpoint = checkpointManager.GetComponent<CurrentCheckpoint>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) //when something (usually the player) touches this object
    {
        SendPosKillCheckpoint(); //this function call cahnages where the current checkpoint is located, it changes where the player will start being sent by meanies/'respawning'
    }

    void SendPosKillCheckpoint()
    {
        currentCheckpoint.currentPosForCheck = localCheckPos; //send the current position to the checkpoint manager and have it save the current checkpoint as this object's position
        Destroy(gameObject); //destroy this object
    }
}
