using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEmotions : MonoBehaviour
{
    [SerializeField]private GameObject EnemyHealthBar;
    [SerializeField]private GameObject playerHealthBar;
    [SerializeField]private GameObject combatCanvas;
    [SerializeField]private GameObject visToSpawn;
    [SerializeField]private EnemyHealthBar enemyHealthScript;
    [SerializeField]private HealthLower healthLower;
    [SerializeField]private AttackInstantiate attackInstantiate;
    [SerializeField]private float damageIDo = 0;
    [SerializeField]private float healthIHeal = 0;
    private bool attacked = false;
    public GameObject holdObject;
    public PlayerVariablesHeld holdScript;
    public int changeSJ = 0;
    public int changeAL = 0;
    public int changeLO = 0;
    public int changeFC = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("PlayerHealthBar") != null) //is there a player?
        {
            playerHealthBar = GameObject.Find("PlayerHealthBar");
            healthLower = playerHealthBar.GetComponent<HealthLower>(); 
        }
        if (GameObject.Find("CombatCanvas") != null) //is there a combat canvas?
        {
            combatCanvas = GameObject.Find("CombatCanvas");
            attackInstantiate = combatCanvas.GetComponent<AttackInstantiate>(); 
        }
        if (GameObject.Find("PlayerVariableHolder") != null) //is there a player?
        {
            holdObject = GameObject.Find("PlayerVariableHolder"); //lets do stuff with the player if it exists
            holdScript = holdObject.GetComponent<PlayerVariablesHeld>(); //maybe find a way to do this so it isnt happening every frame
        } else {
            holdObject = null; //if there isnt a player, dont do stuff with the player
            holdScript = null;
        }
        EnemyHealthBar = GameObject.Find("EnemyHealthBar");
        enemyHealthScript = EnemyHealthBar.GetComponent<EnemyHealthBar>();

        healthIHeal *= -1; //this is confusing but 'health lower' is meant to lower health but this number is supposed to heal, so it gets flipped. Don't mess with this.
    }

    // Update is called once per frame
    void Update()
    {
        if (holdObject != null && !attacked)
        { //there should always be exactly 1 function in this condition that destroys the object, no more no less, and it should be at the end of the result.
            changeEnemyHealth();
            changePlayerHealth();
            spawnVis();
            changeEmotionNumbers(); //make sure this happens last as this function destroys the object.
        }
    }

    private void changeEmotionNumbers()
    {
        holdScript.SadJoyHeld += changeSJ;
        holdScript.AngerLoveHeld += changeAL;
        holdScript.LonelyOverstimulatedHeld += changeLO;
        holdScript.FearConfidenceHeld += changeFC;
        attacked = true;
    }
    
    private void changeEnemyHealth()
    {
        enemyHealthScript.lowerEnemyHealthBar(damageIDo);
    }

    private void changePlayerHealth()
    {
        healthLower.lowerHealthBy(healthIHeal); //this calls a function which changes the player's health bar
    }

    private void spawnVis()
    {
        if (visToSpawn != null)
        {
            Debug.Log("Hi");
            var visSpawned = Instantiate(visToSpawn, new Vector3(1920 / 2,1080 / 2,0), Quaternion.identity);
            visSpawned.transform.parent = combatCanvas.transform;
        }
    }

}
