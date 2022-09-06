using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    float xMove = 0f;
    float yMove = 0f;
    Vector2 playerVelocity = new Vector2(0.0f, 0.0f);
    Rigidbody2D rb;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    void CheckInput()
    {
        xMove = Input.GetAxisRaw ("Horizontal");
        yMove = Input.GetAxisRaw ("Vertical");
    }

    void MovePlayer()
    {
        //rb.AddForce (new Vector2 (xMove, yMove) * speed); <- previous code, saved just in case.

        if (yMove > 0) //checks if the player is trying to move up with their inputs
        {
            if (playerVelocity.y < speed) //caps the speed of the player's movement
            {
                playerVelocity += new Vector2(0.0f, speed); //when the player's velocity updates, it will be set to move up at the speed of 'speed'
            }
        } else if (yMove < 0) //checks if the player is trying to move down
        {
            if (rb.velocity.y > -speed) //caps speed
            {
                playerVelocity -= new Vector2(0.0f, speed); //when the player's velocity updates, it will be set to move down at the speed of 'speed'
            }
        } else //if the player isn't trying to move up or down with their inputs, do the following
        {
            playerVelocity.y = 0.0f; //set the player's y velocity to 0 when the velocity updates
        }
        //the following code is a copy paste of the previous 16 lines but configured for the x value of the player's velocity, not the y value
        if (xMove > 0) 
        {
            if (playerVelocity.x < speed)
            {
                playerVelocity += new Vector2(speed, 0.0f);
            }
        } else if (xMove < 0)
        {
            if (playerVelocity.x > -speed)
            {
                playerVelocity -= new Vector2(speed, 0.0f);
            }
        } else
        {
            playerVelocity.x = 0.0f;
        }
        rb.velocity = playerVelocity; //update the player's velocity to match the variable Vector2 'playerVelocity'
    }

    void Update()
    {
        CheckInput(); //see what the player's inputs are
        MovePlayer(); //move the player
    }
}
