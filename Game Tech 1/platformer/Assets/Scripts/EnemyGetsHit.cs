using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGetsHit : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private Animator enemyAnimator;
    [SerializeField] private PlayerMovement playerMovement; //I'm snagging these for this script so I know whether the player is punching or not.
    [SerializeField] private PlayerAnimation playerAnimation;
    [SerializeField] private GameObject playerHand;
    [SerializeField] private SpriteRenderer handColor;
    [SerializeField] private GameObject playerLeg;
    [SerializeField] private SpriteRenderer legColor;
    [SerializeField] private GameObject thisEnemy;
    private Rigidbody2D _rb;
    private bool justGotHit;
    public bool facingRightButEnemy = true; //yeah i fucked up
    Color handColorActual;
    Color legColorActual;
    //What am I doing? If you have multiple colliders first of all the punching and kicking will bump into walls in bad ways, but if they're triggers they won't store contact info.
    //It's not 'efficient', but I have a hard time getting around that without just comparing positions directly.
    private bool playerIsHitting;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Vector2 whereIAm = new Vector2(thisEnemy.transform.position.x, thisEnemy.transform.position.y);
        Vector2 whereTheHandIs = new Vector2(playerHand.transform.position.x, playerHand.transform.position.y);
        Vector2 whereTheLegIs = new Vector2(playerLeg.transform.position.x, playerLeg.transform.position.y);
        if ((whereIAm.x - whereTheHandIs.x <= 0.5 && whereIAm.x - whereTheHandIs.x >= -0.5 && whereIAm.y - whereTheHandIs.y <= 2 &&  whereIAm.y - whereTheHandIs.y >= -2 )) //Did I just get punched?
        { //Amazing, it's exactly like a box collider 2d set to isTrigger except... again. And therefore worse.
            Debug.Log("ouch!"); //chad
        }

        if ((whereIAm.x - whereTheLegIs.x <= 0.5 && whereIAm.x - whereTheHandIs.x >= -0.5 && whereIAm.y - whereTheHandIs.y <= 2 &&  whereIAm.y - whereTheHandIs.y >= -2 )) //Did I just get kicked?
        {
            Debug.Log("ouch!"); //chad
        }
        This method doesn't work that well...
        
        Made all of that ^ and then thought, "hoooooooly knishes what if I used COLOR?! I'm a genius."
        */
        handColorActual = handColor.color;
        legColorActual = legColor.color;
        //Then it took like 30 minutes to get it working. Not so much of a genius.
    }


    private void Flip()
    {
        facingRightButEnemy = !facingRightButEnemy;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

    void OnTriggerEnter2D(Collider2D other) //Did something just hit me?
    {
        if (playerAnimation.facingRight && facingRightButEnemy)
        {
            Flip();
        } else if (!playerAnimation.facingRight && !facingRightButEnemy)
        {
            Flip();
        }
        float distx = transform.position.x - other.transform.position.x;
        //Debug.Log(dist);
        if (handColorActual.r != 1f) //is the hand not red? If it isn't red (white is red cuz rgb), then it must be green (hand animation makes hand become green when it's normally white)
        {
            //Debug.Log("Ouch!"); // chad
            _rb.AddForce(new Vector2(distx * Time.deltaTime * 20000f, Mathf.Abs(distx * Time.deltaTime * 30000f)));
            enemyAnimator.SetBool("justGotHit", true);
        }
        if (legColorActual.b != 1f) //is the leg not blue? If it isn't blue (white is blue cuz rgb), then it must be yellow/red (nimation makes leg become yellow/red when it's normally white [white is blue])
        {
            //Debug.Log("Ouch!"); // chad
            _rb.AddForce(new Vector2(distx * Time.deltaTime * 10000f, Mathf.Abs(distx * Time.deltaTime * 20000f)));
            enemyAnimator.SetBool("justGotHit", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            enemyAnimator.SetBool("justGotHit", false);
        }
    }
}
