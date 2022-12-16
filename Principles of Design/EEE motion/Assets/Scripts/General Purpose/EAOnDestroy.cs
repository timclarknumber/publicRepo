using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EAOnDestroy : MonoBehaviour
{
    [SerializeField]private GameObject combatCanvas;
    [SerializeField]private AttackInstantiate attackInstantiate;
    void Start()
    {
        if (GameObject.Find("CombatCanvas") != null) //is there a combat canvas?
        {
            combatCanvas = GameObject.Find("CombatCanvas");
            attackInstantiate = combatCanvas.GetComponent<AttackInstantiate>(); 
        }
    }
    void OnDestroy()
    {
        attackInstantiate.spawnEnemyAttackL1();
    }
}
