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
    [SerializeField] private TMP_Text ovenMaxTxt; 
    [SerializeField] private TMP_Text heldMaxText; 
    [SerializeField] private TMP_Text readyMaxTxt; 
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private Color redColor;
    [SerializeField] private Color invisibleColor;

    void Update()
    {
        readyPizzaTxt.text = "Pizzas Ready: " + statHolder.readyPizzas.ToString();
        heldPizzaTxt.text = "Pizzas Held: " + statHolder.playerHeldPizzas.ToString();
        ovenPizzaTxt.text = "Pizzas in Oven: " + statHolder.pizzasInOvenNow.ToString();
        moneyTxt.text = "Money: $" + statHolder.money.ToString();
        timerTxt.text = "Time: " + Mathf.Round(statHolder.timer).ToString();
        if (statHolder.pizzasInOvenNow >= 2)
        {
            ovenMaxTxt.color = redColor;
        } else {
            ovenMaxTxt.color = invisibleColor;
        }
        if (statHolder.playerHeldPizzas >= 3)
        {
            heldMaxText.color = redColor;
        } else {
            heldMaxText.color = invisibleColor;
        }
        if (statHolder.readyPizzas >= 2)
        {
            readyMaxTxt.color = redColor;
        } else {
            readyMaxTxt.color = invisibleColor;
        }
    }
}
