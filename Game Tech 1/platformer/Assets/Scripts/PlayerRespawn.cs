using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    [SerializeField] private Transform respawn;
    private Rigidbody2D _rb;
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    
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
        _rb.velocity = new Vector2(0, 0);
        transform.position = respawn.transform.position;
    }
}
