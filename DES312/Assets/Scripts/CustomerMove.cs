using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMove : MonoBehaviour
{//this script contains the customer move function
    [SerializeField] private SpawnCustomers spawner;
    [SerializeField] private Transform custPos;
    void Start()
    {
        custPos = this.transform;
    }

    public void Move()
    {
        int rando;
        rando = Random.Range(1, 1 + spawner.placesToBe.Count);
        rando--;
        custPos.position = spawner.placesToBe[rando];
    }
}
