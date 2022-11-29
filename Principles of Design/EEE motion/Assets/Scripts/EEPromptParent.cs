using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EEPromptParent : MonoBehaviour
{
    [SerializeField]private Transform thisTransform;
    [SerializeField]private GameObject AttackKey1;
    [SerializeField]private GameObject AttackKey2;

    public void playerCanSeeMe()
    {
        thisTransform.position = new Vector3(365f,320f,0f);
    }

    public void doneWithThisPrompt()
    {
        Destroy(gameObject);
    }

    public void unlockAttack1()
    {
        Instantiate(AttackKey1, new Vector3(0,0,0), Quaternion.identity);
    }

    public void unlockAttack2()
    {
        Instantiate(AttackKey2, new Vector3(0,0,0), Quaternion.identity);
    }
}
