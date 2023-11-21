using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PizzaMakerStats : MonoBehaviour
{ //this script holds the functions called by the pizza making buttons and makes sure more pizzas cannot be baked than the oven limit
    [SerializeField] private SceneScopeStats statHolder;
    [SerializeField] private float lerpTime = 5;
    [SerializeField] private float currentLerp = 0;
    [SerializeField] private bool doughReady = false;
    [SerializeField] private bool sauceReady = false;
    [SerializeField] private bool cheeseReady = false;
    [SerializeField] private bool pepReady = false;
    [SerializeField] private bool callForPep = false;
    [SerializeField] private Button doughButton;
    [SerializeField] private Button sauceButton;
    [SerializeField] private Button cheeseButton;
    [SerializeField] private Button pepButton;
    [SerializeField] private Image DoughImage;
    [SerializeField] private Image SauceImage;
    [SerializeField] private Image CheeseImage;
    [SerializeField] private Image PepImage;
    [SerializeField] private Color invisible;
    [SerializeField] private Color doughColor;
    [SerializeField] private Color sauceColor;
    [SerializeField] private Color cheeseColor;
    [SerializeField] private Color pepColor;
    [SerializeField] private Color grey;
    [SerializeField] private TMP_Text recipeText;
    public void Start()
    {
        doughColor = doughButton.image.color;
        sauceColor = sauceButton.image.color;
        cheeseColor = cheeseButton.image.color;
        pepColor = pepButton.image.color;
    }
    public void Update()
    {
        if (currentLerp <= lerpTime && (doughReady || sauceReady || cheeseReady))
        {
            currentLerp += Time.deltaTime;
        } else if (currentLerp > lerpTime)
        {
            oldFood();
        }
        if (!callForPep)
        {
            recipeText.text = "Dough > Sauce > Cheese > Bake";
        } else
        {
            recipeText.text = "Dough > Sauce > Cheese > Pepperoni > Bake";
        }
        if (doughReady)
        {
            DoughImage.color = Color.Lerp(doughColor, grey, currentLerp / lerpTime);
        } else
        {
            DoughImage.color = invisible;
        }
        if (sauceReady)
        {
            SauceImage.color = Color.Lerp(sauceColor, grey, currentLerp / lerpTime);
        } else
        {
            SauceImage.color = invisible;
        }
        if (cheeseReady)
        {
            CheeseImage.color = Color.Lerp(cheeseColor, grey, currentLerp / lerpTime);
        } else
        {
            CheeseImage.color = invisible;
        }
        if (pepReady)
        {
            PepImage.color = Color.Lerp(pepColor, grey, currentLerp / lerpTime);
        }
        else
        {
            PepImage.color = invisible;
        }
    }

    public void readyDough()
    {
        if (!doughReady)
        {
            Telemetry.beginPizzaPrepareTest();
            doughReady = true;
            doughButton.image.color = invisible;
            currentLerp = 0;
        }
    }
    public void readySauce()
    {
        if (doughReady && !sauceReady)
        {
            sauceReady = true;
            sauceButton.image.color = invisible;
            currentLerp = 0;
        }
    }
    public void readyCheese()
    {
        if (doughReady && sauceReady && !cheeseReady)
        {
            cheeseReady = true;
            cheeseButton.image.color = invisible;
            currentLerp = 0;
        }
    }
    public void readyPep()
    {
        if (doughReady && sauceReady && cheeseReady && !pepReady)
        {
            pepReady = true;
            pepButton.image.color = invisible;
            currentLerp = 0;
        }
    }
    public void bake()
    {
        currentLerp = 0;
        if ((doughReady && sauceReady && cheeseReady && pepReady && callForPep) || (doughReady && sauceReady && cheeseReady && !callForPep && !pepReady))
        {
            if (statHolder.pizzasInOvenNow < 2)
            {
                StartCoroutine(BakeTime());
                statHolder.pizzasInOvenNow++;
            }
        } else if (doughReady)
        {
            statHolder.wasteOfPizza();
        }
        Telemetry.endPizzaPrepareTest();
        doughReady = false;
        sauceReady = false;
        cheeseReady = false;
        pepReady = false;
        doughButton.image.color = doughColor;
        sauceButton.image.color = sauceColor;
        cheeseButton.image.color = cheeseColor;
        pepButton.image.color = pepColor;
        if (statHolder.pepPepPepEnabled)
        {
            pepOrDrep();
        }
    }

    public void oldFood()
    {
        statHolder.wasteOfPizza();
        Telemetry.endPizzaPrepareTest();
        doughReady = false;
        sauceReady = false;
        cheeseReady = false;
        pepReady = false;
        doughButton.image.color = doughColor;
        sauceButton.image.color = sauceColor;
        cheeseButton.image.color = cheeseColor;
        pepButton.image.color = pepColor;
        currentLerp = 0;
        if (statHolder.pepPepPepEnabled)
        {
            pepOrDrep();
        }
    }

    private void pepOrDrep()
    {
        int decider = Random.Range(0,2);
        if (decider == 0)
        {
            callForPep = true;
        } else
        {
            callForPep = false;
        }
    }

    IEnumerator BakeTime()
    {
        yield return new WaitForSeconds(6);
        statHolder.readyPizzas++;
        statHolder.pizzasInOvenNow--;
    }

}
