using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneScopeStats : MonoBehaviour
{//this script keeps track of player stats, also ticks down the timer
    public int readyPizzas;
    public int playerHeldPizzas;
    public int money;
    public int pizzasInOvenNow = 0;
    public float timer;
    public GameObject car;
    [SerializeField] private TMP_Text wasted;
    [SerializeField] private GameObject textParent;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Telemetry.writeToFile("Total Money: $" + money.ToString());
            SceneSwapper.MoveToNextScene();
        }

        if (readyPizzas > 2)
        {
            readyPizzas--;
            money -= 10;
            if (wasted != null && textParent != null)
            {
                Instantiate(wasted, textParent.transform);
            }
        }
    }
}