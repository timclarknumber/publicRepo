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
        xMove = Input.GetAxis ("Horizontal");
        yMove = Input.GetAxis ("Vertical");
    }

    void MovePlayer()
    {
        //rb.AddForce (new Vector2 (xMove, yMove) * speed);
        if (yMove > 0)
        {
            if (playerVelocity.y < speed)
            {
                playerVelocity += new Vector2(0.0f, speed);
            }
        } else if (yMove < 0)
        {
            if (playerVelocity.y > -speed)
            {
                playerVelocity -= new Vector2(0.0f, speed);
            }
        } else
        {
            playerVelocity.y = 0.0f;
        }

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
    }

    void FixedUpdate()
    {
        CheckInput();
        MovePlayer();
        rb.velocity = playerVelocity;
    }
}
