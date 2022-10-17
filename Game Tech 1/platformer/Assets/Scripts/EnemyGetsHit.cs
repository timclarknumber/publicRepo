using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGetsHit : MonoBehaviour
{
    [SerializeField] private Animator playerAnimator;
    [SerializeField] private PlayerMovement playerMovement; //I'm snagging these for this script so I know whether the player is punching or not.
    [SerializeField] private GameObject playerHand;
    [SerializeField] private GameObject playerLeg;
    [SerializeField] private GameObject thisEnemy;
    //What am I doing? If you have multiple colliders first of all the punching and kicking will bump into walls in bad ways, but if they're triggers they won't store contact info.
    //It's not 'efficient', but I have a hard time getting around that without just comparing positions directly.
    private bool playerIsHitting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
