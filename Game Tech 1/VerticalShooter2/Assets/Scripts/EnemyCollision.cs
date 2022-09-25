using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public GameObject explosionPrefab;
    public GameObject healthPanel;
    public HealthBar healthBar;
    public float damageDoneToPlayer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        Instantiate(explosionPrefab, transform.position, transform.rotation);
        healthBar.LoseHealth(damageDoneToPlayer);
    }
}
