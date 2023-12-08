using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerPickupTrigger : MonoBehaviour
{//this script delivers pizza when the player touches the customer and has pizza
//it also moves the customer when they no longer have more demand for pizza by calling the move function stored in CustomerMove and after moving them adds some demand based on maxdemand
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private CustomerMove moveScript;
    [SerializeField] private GameObject car;
    [SerializeField] private Transform customerBox;
    [SerializeField] private int maxDemand = 1;
    [SerializeField] public float customerPatience = 25;
    [SerializeField] public float customerPatienceReset = 15;
    public int neededPizzas;
    // Start is called before the first frame update
    void Start()
    {
        if (car == null && statHolder != null)
        {
            car = statHolder.car;
        }
    }
    void Update()
    {
        if (customerPatience <= customerPatienceReset)
        {
            customerBox.localScale = new Vector3(customerPatience / customerPatienceReset, 1, 1);
        } else
        {
            customerBox.localScale = new Vector3(1, 1, 1);
        }
        customerPatience -= Time.deltaTime;
        if (customerPatience <= 0)
        {
            customerPatience = customerPatienceReset;
            moveScript.Move();
            statHolder.wasteOfPizza();
        }
    }

    private void OnTriggerStay(Collider car)
    {
        DeliverPizza();
        customerPatience = customerPatienceReset;
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
            Telemetry.endDeliverySpeedTest();
        }
    }
}
