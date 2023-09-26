using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaMakerStats : MonoBehaviour
{
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private bool doughReady = false;
    [SerializeField] private bool sauceReady = false;
    [SerializeField] private bool cheeseReady = false;
    

    public void readyDough()
    {
        if (!doughReady)
        {
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
            StartCoroutine(BakeTime());
            doughReady = false;
            sauceReady = false;
            cheeseReady = false;
        }
    }
    
    IEnumerator BakeTime()
    {
        yield return new WaitForSeconds(5);
        statHolder.readyPizzas++;
    }
}
