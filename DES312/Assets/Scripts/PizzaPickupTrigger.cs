using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaPickupTrigger : MonoBehaviour
{//this script gives pizza to the player by subtracting from ready pizza and adding to held pizza when the script owner is collided into by the player
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

    private void OnTriggerStay(Collider car)
    {
        GivePizza();
    }

    private void GivePizza()
    {
        while(statHolder.readyPizzas > 0 && statHolder.playerHeldPizzas <= 2)
        {
            statHolder.playerHeldPizzas++;
            statHolder.readyPizzas--;
            Telemetry.beginDeliverySpeedTest();
        }
    }
}
