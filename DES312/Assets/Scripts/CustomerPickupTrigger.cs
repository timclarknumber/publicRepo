using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerPickupTrigger : MonoBehaviour
{
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private GameObject car;
    [SerializeField] private int neededPizzas;
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
