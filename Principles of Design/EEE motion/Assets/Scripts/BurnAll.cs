using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnAll : MonoBehaviour
{
    [SerializeField]private GameObject playerVariableHolder;
    [SerializeField]private GameObject enemyInfo;
    [SerializeField]private GameObject ComeToMe;
    [SerializeField]private GameObject WinStateCounter;
    [SerializeField]private GameObject PlayerAttackKey1;
    [SerializeField]private GameObject PlayerAttackKey2;
    [SerializeField]private GameObject PlayerAttackKey3;
    [SerializeField]private GameObject PlayerAttackKey4;
    [SerializeField]private GameObject PlayerAttackKey5;
    [SerializeField]private GameObject PlayerAttackKey6;
    [SerializeField]private GameObject PlayerAttackKey7;
    [SerializeField]private GameObject PlayerAttackKey8;
    [SerializeField]private GameObject PlayerAttackKey9;
    [SerializeField]private GameObject PlayerAttackKey10;
    }
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
        
        if (GameObject.Find("PlayerAttackKey1(Clone)") != null) //if there is a player attack key clone
        {
            PlayerAttackKey1 = GameObject.Find("PlayerAttackKey1(Clone)"); //burn it 
            Destroy(PlayerAttackKey1);
        }
        
        if (GameObject.Find("PlayerAttackKey2(Clone)") != null) 
        {
            PlayerAttackKey2 = GameObject.Find("PlayerAttackKey2(Clone)"); //burn it 
            Destroy(PlayerAttackKey2);
        }
        
        if (GameObject.Find("PlayerAttackKey3(Clone)") != null)
        {
            PlayerAttackKey3 = GameObject.Find("PlayerAttackKey3(Clone)"); //burn it 
            Destroy(PlayerAttackKey3);
        }
        
        if (GameObject.Find("PlayerAttackKey4(Clone)") != null)
        {
            PlayerAttackKey4 = GameObject.Find("PlayerAttackKey4(Clone)"); //burn it 
            Destroy(PlayerAttackKey4);
        }
        
        if (GameObject.Find("PlayerAttackKey5(Clone)") != null) 
        {
            PlayerAttackKey5 = GameObject.Find("PlayerAttackKey5(Clone)"); //burn it 
            Destroy(PlayerAttackKey5);
        }
        
        if (GameObject.Find("PlayerAttackKey6(Clone)") != null) 
        {
            PlayerAttackKey6 = GameObject.Find("PlayerAttackKey6(Clone)"); //burn it 
            Destroy(PlayerAttackKey6);
        }
        
        if (GameObject.Find("PlayerAttackKey7(Clone)") != null) 
        {
            PlayerAttackKey7 = GameObject.Find("PlayerAttackKey7(Clone)"); //burn it 
            Destroy(PlayerAttackKey7);
        }
        
        if (GameObject.Find("PlayerAttackKey8(Clone)") != null) 
        {
            PlayerAttackKey8 = GameObject.Find("PlayerAttackKey8(Clone)"); //burn it 
            Destroy(PlayerAttackKey8);
        }
        
        if (GameObject.Find("PlayerAttackKey9(Clone)") != null)
        {
            PlayerAttackKey9 = GameObject.Find("PlayerAttackKey9(Clone)"); //burn it 
            Destroy(PlayerAttackKey9);
        }
        
        if (GameObject.Find("PlayerAttackKey10(Clone)") != null)
        {
            PlayerAttackKey10 = GameObject.Find("PlayerAttackKey10(Clone)"); //burn it 
            Destroy(PlayerAttackKey10);
        }
    }
}