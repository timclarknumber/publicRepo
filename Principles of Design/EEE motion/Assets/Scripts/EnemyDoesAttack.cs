using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDoesAttack : MonoBehaviour
{
    [SerializeField]private GameObject playerHealthBar;
    [SerializeField]private HealthLower healthLowerScript;
    [SerializeField]private float damageDealt = 10;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("PlayerHealthBar") != null) //you know what a bad bih programmer would do? Make this into a function. Too bad that aint me.
        {
            playerHealthBar = GameObject.Find("PlayerHealthBar");
            healthLowerScript = playerHealthBar.GetComponent<HealthLower>();
            healthLowerScript.lowerHealthBy(damageDealt);
            Destroy(gameObject);
        }
    }
}
