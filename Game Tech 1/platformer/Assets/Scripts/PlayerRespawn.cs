using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    [SerializeField] private Transform respawn;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            //Respawn
            RespawnThePlayer(); //I did it this way so I can use this function elsewhere.
        }
        else if (other.gameObject.CompareTag("Checkpoint"))
        {
            //Respawn
            respawn = other.transform;
        }
    }

    public void RespawnThePlayer()
    {
        transform.position = respawn.transform.position;
    }
}
