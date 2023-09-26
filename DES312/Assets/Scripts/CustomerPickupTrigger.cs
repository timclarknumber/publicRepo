using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerPickupTrigger : MonoBehaviour
{//this script delivers pizza when the player touches the customer and has pizza
//it also moves the customer when they no longer have more demand for pizza by calling the move function stored in CustomerMove and after moving them adds some demand based on maxdemand
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private CustomerMove moveScript;
    [SerializeField] private GameObject car;
    [SerializeField] private int maxDemand = 1;
    public int neededPizzas;
    // Start is called before the first frame update
    void Start()
    {
        if (car == null && statHolder != null)
        {
            car = statHolder.car;
        }
    }

    private void OnTriggerEnter(Collider car)
    {
        DeliverPizza();
        if (neededPizzas <= 0)
        {
            moveScript.Move();
            neededPizzas += Random.Range(1, maxDemand + 1);
        }
    }

    private void DeliverPizza()
    {
        while (statHolder.playerHeldPizzas > 0 && neededPizzas > 0)
        {
            statHolder.playerHeldPizzas--;
            neededPizzas--;
            statHolder.money += 10;
        }
    }
}
