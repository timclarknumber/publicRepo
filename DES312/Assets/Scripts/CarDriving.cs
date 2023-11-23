using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriving : MonoBehaviour
{//this script handles the movement of the player in their car
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private Transform model;
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
                model.transform.eulerAngles = new Vector3(135, 90, -90);
                Telemetry.carIsMoving(true);
            } 
            else if (Input.GetKey("w") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,adjustedSpeed,0);
                model.transform.eulerAngles = new Vector3(225, 90, -90);
                Telemetry.carIsMoving(true);
            } 
            else if (Input.GetKey("s") && Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-adjustedSpeed,-adjustedSpeed,0);
                model.transform.eulerAngles = new Vector3(45, 90, -90);
                Telemetry.carIsMoving(true);
            } 
            else if (Input.GetKey("s") && Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,-adjustedSpeed,0);
                model.transform.eulerAngles = new Vector3(315, 90, -90);
                Telemetry.carIsMoving(true);
            } 
            else if (Input.GetKey("w"))
            {
                rb.velocity = new Vector3(0,adjustedSpeed,0);
                model.transform.eulerAngles = new Vector3(180, 90, -90);
                Telemetry.carIsMoving(true);
            } 
            else if (Input.GetKey("a"))
            {
                rb.velocity = new Vector3(-adjustedSpeed,0,0);
                model.transform.eulerAngles = new Vector3(90, 90, -90);
                Telemetry.carIsMoving(true);
            }
            else if (Input.GetKey("d"))
            {
                rb.velocity = new Vector3(adjustedSpeed,0,0);
                model.transform.eulerAngles = new Vector3(270, 90, -90);
                Telemetry.carIsMoving(true);
            }
            else if (Input.GetKey("s"))
            {
                rb.velocity = new Vector3(0,-adjustedSpeed,0);
                model.transform.eulerAngles = new Vector3(0, 90, -90);
                Telemetry.carIsMoving(true);
            } else 
            {
                rb.velocity = new Vector3(0,0,0);
                Telemetry.carIsMoving(false);
            }
        }

        Telemetry.playerXMeasured = this.transform.position.x;
        Telemetry.playerYMeasured = this.transform.position.y;
        
    }

    
    private void OnTriggerEnter(Collider Highway)
    {
        if (Highway.CompareTag("Highway"))
        {
            speed = 600;
            Telemetry.enterHighway();
        }
    }
    
    private void OnTriggerExit(Collider Highway)
    {
        if (Highway.CompareTag("Highway"))
        {
            speed = 300;
            Telemetry.exitHighway();
        }
    }
    
}
