using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDemand : MonoBehaviour
{
    [SerializeField] private CustomerPickupTrigger pickup;
    private int wantPizza;
    private int timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (pickup == null)
        {
            pickup = this.GetComponent<CustomerPickupTrigger>();
        }
    }

    // Update is called once per frame
    void Update()
    {/*
        timer -= time.deltaTime;
        if (timer < 1)
        {
            wantPizza = Random.Range(1,3);
            timer = 1;
        }
        if (pickup.neededPizzas == 0 && wantPizza == 2)
        {
            pickup.neededPizzas++;
        }*/
    }
}
