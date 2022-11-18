using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]private float myHealth = 0;
    [SerializeField]private float myDamage = 0;
    [SerializeField]private string mySprite = "";
    [SerializeField]private Transform playerTransform;
    [SerializeField]private Transform thisTransform;
    [SerializeField]private SceneSwapCombat sceneScript;
    [SerializeField]private EnemyInfoHolder enemyInfoHeld;
    [SerializeField]private GameObject sceneBruh;
    [SerializeField]private GameObject ComeToMe;
    [SerializeField]private GameObject ComeToMePrefab;
    [SerializeField]private GameObject variableHolder;
    [SerializeField]private string myName;

    private float playerX;
    private float playerY;
    private float thisX;
    private float thisY;
    // Start is called before the first frame update
    void Start()
    {
        thisX = thisTransform.position.x;
        thisY = thisTransform.position.y;
        variableHolder = GameObject.Find("EnemyInfoHolder");
        enemyInfoHeld = variableHolder.GetComponent<EnemyInfoHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        playerX = playerTransform.position.x; //keep track of where the player is
        playerY = playerTransform.position.y;
        if(playerX < thisX + 0.5 && playerX > thisX - 0.5 && playerY < thisY + 0.5 && playerY > thisY - 0.5) //if the player is touching me
        {
            enemyInfoHeld.enemyHealth = myHealth;
            enemyInfoHeld.enemyDamage = myDamage;
            enemyInfoHeld.enemySprite = mySprite;
            sceneScript.GoToCombat(myName); //send the user to the combat scene
            if (GameObject.Find("ComeToMe(Clone)") == null) //if there isnt a come to me yet
            {
                Instantiate(ComeToMePrefab, thisTransform.position, Quaternion.identity); //make a come to me
            }
            
        }
        if (GameObject.Find("ComeToMe") != null) //if there is a come to me
        {
            ComeToMe = GameObject.Find("ComeToMe"); //do stuff with the come to me
            if (ComeToMe.transform.position.x < thisX + 0.5 && ComeToMe.transform.position.x > thisX - 0.5 && ComeToMe.transform.position.y < thisY + 0.5 && ComeToMe.transform.position.y > thisY - 0.5)
            { //^ if the come to me is touching me
                Destroy(gameObject); //damn...
            }
        }
        if (GameObject.Find("ComeToMe(Clone)") != null) //`` but with clone because its a prefab so yeah.
        {
            ComeToMe = GameObject.Find("ComeToMe(Clone)");
            if (ComeToMe.transform.position.x < thisX + 0.5 && ComeToMe.transform.position.x > thisX - 0.5 && ComeToMe.transform.position.y < thisY + 0.5 && ComeToMe.transform.position.y > thisY - 0.5)
            {
                Destroy(gameObject);
            }
        }
    }
}
