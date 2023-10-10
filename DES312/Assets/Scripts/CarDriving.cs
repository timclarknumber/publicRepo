using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{//this script handles the movement of the player in their car
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    private float adjustedSpeed;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        adjustedSpeed = speed * Time.deltaTime;
        if (rb != null)
        {
            if (Input.GetKey("w") && Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-adjustedSpeed,adjustedSpeed,0);
            } 
            else if (Input.GetKey("w") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,adjustedSpeed,0);
            } 
            else if (Input.GetKey("s") && Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-adjustedSpeed,-adjustedSpeed,0);
            } 
            else if (Input.GetKey("s") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,-adjustedSpeed,0);
            } 
            else if (Input.GetKey("w"))
            {
                rb.velocity = new Vector3(0,adjustedSpeed,0);
            } 
            else if (Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-adjustedSpeed,0,0);
            }
            else if (Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,0,0);
            }
            else if (Input.GetKey("s"))
            {
                rb.velocity = new Vector3(0,-adjustedSpeed,0);
            } else 
            {
                rb.velocity = new Vector3(0,0,0);
            }
        }

        Telemetry.playerXMeasured = this.transform.position.x;
        Telemetry.playerYMeasured = this.transform.position.y;
        
    }

    
    private void OnTriggerEnter(Collider Highway)
    { 
        speed = 850;
    }
    
    private void OnTriggerExit(Collider Highway)
    {
        speed = 350;
    }
    
}
