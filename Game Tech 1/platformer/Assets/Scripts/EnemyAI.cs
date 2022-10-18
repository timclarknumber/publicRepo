using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private float farthestExtentRight = 0f; //we are going to change these in the editor.
    [SerializeField] private float farthestExtentLeft = 0f;
    [SerializeField] private float xSpeed = 10f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckRadius = 0.1f;
    [SerializeField] private EnemyGetsHit enemyGetsHit;
    private float stopAndThink = 3f;
    private float whenToThink = 3f;
    public float EnemyXSpeed => xSpeed;
    private Rigidbody2D _rb;
    private bool _isGrounded;
    public bool EnemyIsGrounded => _isGrounded;
    private bool _IShouldBeMovingRight = true;

    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, groundCheckRadius, groundLayer);
        _isGrounded = col != null;


        if (!enemyGetsHit.enemyGotHit) //none of what happens here can happen if the enemy just got hit by something.
        {
            //the below if and else if statements will make the enemy switch the direction of where they are moving. Note: NOT the same as flipping them around visually.
            if (transform.position.x > farthestExtentRight)
            {
                _IShouldBeMovingRight = false;
            } else if (transform.position.x < farthestExtentLeft)
            {
                _IShouldBeMovingRight = true;
            }

            //the following if and else statements will change the speed depending on if the enemy should be going right or left
            if (_IShouldBeMovingRight)
            {
                xSpeed = Mathf.Abs(xSpeed);
                if (!enemyGetsHit.facingRightButEnemy)
                {
                    enemyGetsHit.Flip();
                }
            } else {
                xSpeed = -Mathf.Abs(xSpeed); //dumbest method ive ever written but who cares. The alternative was using more variables.
                if (enemyGetsHit.facingRightButEnemy)
                {
                    enemyGetsHit.Flip();
                }
            }

            //the following if and else statements cause the AI to stop every once in a while so it can do the headscratch animation as if it is thinking.
            if (whenToThink >= 0.1f)
            {
                _rb.velocity = new Vector2(xSpeed, _rb.velocity.y); //moving normally (IMPOTANT, IF YOU ARE LOOKING FOR WHAT IS ACTUALLY MOVING ENEMY, IT'S THIS)
                whenToThink -= 1 * Time.deltaTime; //count down till time to think
            } else {
                _rb.velocity = new Vector2(0f, _rb.velocity.y); //dont move if thinking
                stopAndThink -= 1 * Time.deltaTime; //count down the amount of time spent thinking
                if (stopAndThink <= 0.1f) //when you run out of time to think, reset both of the timers.
                {
                    stopAndThink = 3f;
                    //Hadouuuken.
                    whenToThink = 3f;
                }
            }
        }
    }
}
