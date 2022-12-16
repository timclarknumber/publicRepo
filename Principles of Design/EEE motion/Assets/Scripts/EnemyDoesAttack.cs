using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoesAttack : MonoBehaviour
{
    [SerializeField]private GameObject playerHealthBar;
    [SerializeField]private GameObject enemyInfoHolderObj;
    [SerializeField]private EnemyInfoHolder enemyInfoHolderScr;
    [SerializeField]private HealthLower healthLowerScript;
    [SerializeField]private float damageDealt = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("EnemyInfoHolder") != null)
        {
            enemyInfoHolderObj = GameObject.Find("EnemyInfoHolder");
            enemyInfoHolderScr = enemyInfoHolderObj.GetComponent<EnemyInfoHolder>();
            damageDealt = enemyInfoHolderScr.enemyDamage;
        }
    }

    void Update()
    {
        attackPlayer();
        Destroy(gameObject);
    }

    private void attackPlayer()
    {
        if (GameObject.Find("PlayerHealthBar") != null) //you know what a bad bih programmer would do? Make this into a function. Too bad that aint me.
        {
            playerHealthBar = GameObject.Find("PlayerHealthBar");
            healthLowerScript = playerHealthBar.GetComponent<HealthLower>();
            healthLowerScript.lowerHealthBy(damageDealt);
        }
    }
}
