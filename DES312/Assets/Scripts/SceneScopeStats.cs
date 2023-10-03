using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneScopeStats : MonoBehaviour
{//this script keeps track of player stats, also ticks down the timer
    public int readyPizzas;
    public int playerHeldPizzas;
    public int money;
    public int pizzasInOvenNow = 0;
    public float timer;
    public GameObject car;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Telemetry.writeToFile("Total Money: $" + money.ToString());
            SceneSwapper.MoveToNextScene();
        }
    }
}
