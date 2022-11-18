using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInfoHolder : MonoBehaviour
{
    public float enemyHealth = 0;
    public float enemyDamage = 0;
    public string enemySprite = "";
    void Awake()
    {
        DontDestroyOnLoad(gameObject); //don kill me vro
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
