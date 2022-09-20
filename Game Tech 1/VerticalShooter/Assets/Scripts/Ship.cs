using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public GameObject explosionPrefab;

    int damage = 0;

    void OnCollisionEnter2d(Collision2D collision)
    {
        Instantiate(explosionPrefab, transform.position, transform.rotation);

        GameManager.singleton.UpdateHealth(damage);
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
