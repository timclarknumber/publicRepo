using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInstantiate : MonoBehaviour
{
    public GameObject AttackSad;
    public GameObject AttackHappy;
    public GameObject AttackAfraid;
    public GameObject AttackConfident;
    public GameObject AttackFearOfClowns;
    public GameObject AttackHatredOfClowns;
    public GameObject AttackFamilialLove;
    public GameObject AttackResentment;
    public GameObject EnemyAttackL1;

    public void spawnAttackSad()
    {
        Instantiate(AttackSad, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackHappy()
    {
        Instantiate(AttackHappy, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackAfraid()
    {
        Instantiate(AttackAfraid, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackConfident()
    {
        Instantiate(AttackConfident, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackFearOfClowns()
    {
        Instantiate(AttackFearOfClowns, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackHatredOfClowns()
    {
        Instantiate(AttackHatredOfClowns, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackFamilialLove()
    {
        Instantiate(AttackFamilialLove, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnAttackResentment()
    {
        Instantiate(AttackResentment, new Vector3(0,0,0), Quaternion.identity);
    }

    public void spawnEnemyAttackL1()
    {
        Instantiate(EnemyAttackL1, new Vector3(0,0,0), Quaternion.identity);
    }
}
