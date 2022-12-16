using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EEPromptParent : MonoBehaviour
{
    [SerializeField]private Transform thisTransform;
    [SerializeField]private GameObject AttackKey1;
    [SerializeField]private GameObject AttackKey2;
    [SerializeField]private playerMovement PlayerMovement;

    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            PlayerMovement = GameObject.Find("Player").GetComponent<playerMovement>();
        }
        if(thisTransform.position.y >= 300f)
        {
            PlayerMovement.lookingAtMenu = true;
        }
    }

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
    
    void OnDestroy()
    {
<<<<<<< HEAD
        PlayerMovement.lookingAtMenu = false;
=======
            PlayerMovement.lookingAtMenu = false;
>>>>>>> 18941a12e46d00df8402d31afe5f4f6bbeb68f4c
    }
}
