using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PizzaMakerStats : MonoBehaviour
{ //this script holds the functions called by the pizza making buttons and makes sure more pizzas cannot be baked than the oven limit
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private bool doughReady = false;
    [SerializeField] private bool sauceReady = false;
    [SerializeField] private bool cheeseReady = false;
    [SerializeField] private Button doughButton;
    [SerializeField] private Button sauceButton;
    [SerializeField] private Button cheeseButton;
    [SerializeField] private Color invisible;
    [SerializeField] private Color doughColor;
    [SerializeField] private Color sauceColor;
    [SerializeField] private Color cheeseColor;

    public void Start()
    {
        doughColor = doughButton.image.color;
        sauceColor = sauceButton.image.color;
        cheeseColor = cheeseButton.image.color;
    }
    public void readyDough()
    {
        if (!doughReady)
        {
            Telemetry.beginPizzaPrepareTest();
            doughReady = true;
            doughButton.image.color = invisible;
        }
    }
    public void readySauce()
    {
        if (doughReady && !sauceReady)
        {
            sauceReady = true;
            sauceButton.image.color = invisible;
        }
    }
    public void readyCheese()
    {
        if (doughReady && sauceReady && !cheeseReady)
        {
            cheeseReady = true;
            cheeseButton.image.color = invisible;
        }
    }
    public void bake()
    {
        if (doughReady && sauceReady && cheeseReady)
        {
            if (statHolder.pizzasInOvenNow < 2 && statHolder.readyPizzas < 2)
            {
                Telemetry.endPizzaPrepareTest();
                StartCoroutine(BakeTime());
                statHolder.pizzasInOvenNow++;
            }
            doughReady = false;
            sauceReady = false;
            cheeseReady = false;
            doughButton.image.color = doughColor;
            sauceButton.image.color = sauceColor;
            cheeseButton.image.color = cheeseColor;
        }
    }
    
    IEnumerator BakeTime()
    {
        yield return new WaitForSeconds(6);
        statHolder.readyPizzas++;
        statHolder.pizzasInOvenNow--;
    }
}
