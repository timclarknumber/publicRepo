using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class SceneScopeStats : MonoBehaviour
{//this script keeps track of player stats, also ticks down the timer
    public int readyPizzas;
    public int playerHeldPizzas;
    public int money;
    public int pizzasInOvenNow = 0;
    public float timer;
    public string sceneNext;
    public bool pepPepPepEnabled = false;
    public GameObject car;
    [SerializeField] private bool inTutorial = false;
    [SerializeField] private TMP_Text wasted;
    [SerializeField] private GameObject textParent;

    private void Start()
    {
        Telemetry.writeToFile("Start of a level.");
        Telemetry.saveFile();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Telemetry.levelMoneyTotal(money);
            SceneSwapper.MoveToNextScene(sceneNext);
        }

        if (readyPizzas > 2)
        {
            readyPizzas--;
            wasteOfPizza();
        }
        if (money > 40 && inTutorial)
        {
            Telemetry.WriteTutorialTime();
            SceneSwapper.ExitTutorial();
        }
    }

    public void wasteOfPizza()
    {
        money -= 10;
        if (wasted != null && textParent != null)
        {
            Instantiate(wasted, textParent.transform);
        }
    }
}
