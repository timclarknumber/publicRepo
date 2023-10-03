using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMakerStats : MonoBehaviour
{ //this script holds the functions called by the pizza making buttons and makes sure more pizzas cannot be baked than the oven limit
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private bool doughReady = false;
    [SerializeField] private bool sauceReady = false;
    [SerializeField] private bool cheeseReady = false;

    public void readyDough()
    {
        if (!doughReady)
        {
            Telemetry.beginPizzaPrepareTest();
            doughReady = true;
        }
    }
    public void readySauce()
    {
        if (doughReady && !sauceReady)
        {
            sauceReady = true;
        }
    }
    public void readyCheese()
    {
        if (doughReady && sauceReady && !cheeseReady)
        {
            cheeseReady = true;
        }
    }
    public void bake()
    {
        if (doughReady && sauceReady && cheeseReady)
        {
            if (statHolder.pizzasInOvenNow < 2)
            {
                Telemetry.endPizzaPrepareTest();
                StartCoroutine(BakeTime());
                statHolder.pizzasInOvenNow++;
            }
            doughReady = false;
            sauceReady = false;
            cheeseReady = false;
        }
    }
    
    IEnumerator BakeTime()
    {
        yield return new WaitForSeconds(6);
        statHolder.readyPizzas++;
        statHolder.pizzasInOvenNow--;
    }
}
