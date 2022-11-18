using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVariablesReset : MonoBehaviour
{
    private GameObject enemyInfoHolder;
    private EnemyInfoHolder enemyInfo;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("EnemyInfoHolder") == null) 
        {
            enemyInfoHolder = GameObject.Find("EnemyInfoHolder");
            enemyInfo = enemyInfoHolder.GetComponent<EnemyInfoHolder>();
            enemyInfo.enemyDamage = 0f;
            enemyInfo.enemyHealth = 0f;
            enemyInfo.enemySprite = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
