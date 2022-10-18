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
    public bool IShouldBeMovingRight = true;

    
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
            if (transform.position.x > farthestExtentRight)
            {
                IShouldBeMovingRight = false;
            } else if (transform.position.x < farthestExtentLeft)
            {
                IShouldBeMovingRight = true;
            }
            //the following if and else statements will change the speed depending on if the enemy should be going right or
            if (IShouldBeMovingRight)
            {
                xSpeed = Mathf.Abs(xSpeed);
            } else {
                xSpeed = -Mathf.Abs(xSpeed);
            }

            //the following if and else statements cause the AI to stop every once in a while so it can do the headscratch animation as if it is thinking.
            if (whenToThink >= 0.1f)
            {
                _rb.velocity = new Vector2(xSpeed, _rb.velocity.y);
                whenToThink -= 1 * Time.deltaTime;
            } else {
                _rb.velocity = new Vector2(0f, _rb.velocity.y);
                stopAndThink -= 1 * Time.deltaTime;
                if (stopAndThink <= 0.1f)
                {
                    stopAndThink = 3f;
                    whenToThink = 3f;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
