using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeToMe : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    private GameObject player;
    private float playerX;
    private float playerY;
    private float thisX;
    private float thisY;
    [SerializeField]private float donKillMeBro = 1f;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject); //don kill me vro
    }
    void Start()
    {
        if (GameObject.Find("Player") != null) //is there a player?
        {
            player = GameObject.Find("Player"); //lets do stuff with the player if it exists
        } else {
            player = null; //if there isnt a player, dont do stuff with the player
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("CombatCanvas") != null) //are we on the combat scene?
        {
            donKillMeBro += Time.deltaTime; //if we are in the combat scene, don kill me bro
        }
        if (GameObject.Find("Player") != null) //is there a player?
        {
            player = GameObject.Find("Player"); //lets do stuff with the player if it exists
        } else {
            player = null; //if there isnt a player, dont do stuff with the player
        }
        donKillMeBro -= Time.deltaTime; //PLEAAAAAAAASE BGRO PLEAAESEEEEEEE
        thisX = transform.position.x;
        thisY = transform.position.y;
        
        if (player != null) //if the player exists...
        {
            playerX = player.transform.position.x; //keep track of where the player is
            playerY = player.transform.position.y;
            if(playerX < thisX + 0.5 && playerX > thisX - 0.5 && playerY < thisY + 0.5 && playerY > thisY - 0.5) //if im touching the player
            {
                Destroy(gameObject); //damn...
            } else if(donKillMeBro < 0) { //if don kill me
                player.transform.position = new Vector3 (thisX, thisY, player.transform.position.z); //bring the player to me (wow, its almost like thats what this script and object are named after!)
            }
        }
    }
}
