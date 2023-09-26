using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UISats : MonoBehaviour
{//this script just updates all the UI objects that display data using stats from statholder
    [SerializeField] private TMP_Text readyPizzaTxt; 
    [SerializeField] private TMP_Text heldPizzaTxt; 
    [SerializeField] private TMP_Text ovenPizzaTxt; 
    [SerializeField] private TMP_Text moneyTxt; 
    [SerializeField] private TMP_Text timerTxt; 
    [SerializeField] private SceneScopeStats statHolder;

    // Update is called once per frame
    void Update()
    {
        readyPizzaTxt.text = "Pizzas Ready: " + statHolder.readyPizzas.ToString();
        heldPizzaTxt.text = "Pizzas Held: " + statHolder.playerHeldPizzas.ToString();
        ovenPizzaTxt.text = "Pizzas in Oven: " + statHolder.pizzasInOvenNow.ToString();
        moneyTxt.text = "Money: $" + statHolder.money.ToString();
        timerTxt.text = "Time: " + Mathf.Round(statHolder.timer).ToString();
    }
}
