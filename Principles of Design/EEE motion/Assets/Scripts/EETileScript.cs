using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EETileScript : MonoBehaviour
{
    [SerializeField]private string promptISummonName = "EEPrompt1";
    [SerializeField]private GameObject promptISummon;
    [SerializeField]private EEPromptParent promptScript;
    [SerializeField]private Transform playerTransform;
    [SerializeField]private Transform thisTransform;

    private float playerX;
    private float playerY;
    private float thisX;
    private float thisY;
    // Start is called before the first frame update

    void Awake()
    {
        DontDestroyOnLoad(gameObject); //don kill me vro
    }

    void Update()
    {
        thisX = thisTransform.position.x;
        thisY = thisTransform.position.y;

        if (GameObject.Find("Player") != null) //is there a player?
        {
            playerTransform = GameObject.Find("Player").transform;
        } else {
            playerTransform = null;
        }

        if (playerTransform != null) //is there a player?
        {
            playerX = playerTransform.position.x; //keep track of where the player is
            playerY = playerTransform.position.y;
            if(playerX < thisX + 0.5 && playerX > thisX - 0.5 && playerY < thisY + 0.5 && playerY > thisY - 0.5) //if the player is touching me
            {
                summonPrompt();
            }
        }
    }

    void summonPrompt()
    {
        if (GameObject.Find(promptISummonName) != null) 
        {
            promptISummon = GameObject.Find(promptISummonName);
            promptScript = promptISummon.GetComponent<EEPromptParent>();
            promptScript.playerCanSeeMe();
            thisTransform.position = new Vector3 (5000f, 5000f, 0f);
        }
    }
}
