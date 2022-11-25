using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInstantiate : MonoBehaviour
{
    public GameObject AttackSl1;
    public GameObject EnemyAttackL1;

    public void spawnAttackSl1()
    {
        Instantiate(AttackSl1, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnEnemyAttackL1()
    {
        Instantiate(EnemyAttackL1, new Vector3(0,0,0), Quaternion.identity);
    }
}
