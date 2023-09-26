using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPickupTrigger : MonoBehaviour
{
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private GameObject car;
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
        GivePizza();
    }

    private void GivePizza()
    {
        while(statHolder.readyPizzas > 0)
        {
            statHolder.playerHeldPizzas++;
            statHolder.readyPizzas--;
        }
    }
}
