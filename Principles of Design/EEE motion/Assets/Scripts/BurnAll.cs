using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnAll : MonoBehaviour
{
    [SerializeField]private GameObject playerVariableHolder;
    [SerializeField]private GameObject enemyInfo;
    [SerializeField]private GameObject ComeToMe;
    [SerializeField]private GameObject WinStateCounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerVariableHolder") != null) //if there is a player variable holder
        {
            playerVariableHolder = GameObject.Find("PlayerVariableHolder"); //burn it 
            Destroy(playerVariableHolder);
        }
        
        if (GameObject.Find("EnemyInfoHolder") != null) //if there is an enemy info holder
        {
            enemyInfo = GameObject.Find("EnemyInfoHolder"); //burn it 
            Destroy(enemyInfo);
        }

        if (GameObject.Find("ComeToMe") != null) //if there is a come to me
        {
            ComeToMe = GameObject.Find("ComeToMe"); //burn it 
            Destroy(ComeToMe); //damn...
        }
        if (GameObject.Find("ComeToMe(Clone)") != null) //if there is a come to me clone
        {
            ComeToMe = GameObject.Find("ComeToMe(Clone)"); //burn it 
            Destroy(ComeToMe);
        }
        if (GameObject.Find("WinStateCounter") != null) //if there is a win state counter 
        {
            WinStateCounter = GameObject.Find("WinStateCounter"); //burn it 
            Destroy(WinStateCounter);
        }
    }
}