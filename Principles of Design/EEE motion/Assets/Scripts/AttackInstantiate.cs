using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInstantiate : MonoBehaviour
{
    public GameObject AttackSl1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnAttackSl1()
    {
        Instantiate(AttackSl1, new Vector3(0,0,0), Quaternion.identity);
    }
}
