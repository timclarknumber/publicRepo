using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DescriptorText : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI thisText;
    [SerializeField]private GameObject playerVariableHolder;
    [SerializeField]private PlayerVariablesHeld playerVariablesHeld;
    [SerializeField]private int whichAmI;

    private int numberICareAbout;
    private string textISay;


    void Start()
    {
        if (GameObject.Find("PlayerVariableHolder") != null)
        {
            playerVariableHolder = GameObject.Find("PlayerVariableHolder");
            playerVariablesHeld = playerVariableHolder.GetComponent<PlayerVariablesHeld>(); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(playerVariablesHeld != null)
        {
            if (whichAmI == 1)
            {
                numberICareAbout = playerVariablesHeld.SadJoyHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Utterly depressed";
                    thisText.color = new Color32(0, 59, 255, 255);
                } else if (numberICareAbout == -1)
                {
                    textISay = "A bit sad";
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to sadness and joy";
                } else if (numberICareAbout == 1)
                {
                    textISay = "Cheery";
                } else if (numberICareAbout == 2)
                {
                    textISay = "Joyous!";
                }
            } else if (whichAmI == 2)
            { 
                numberICareAbout = playerVariablesHeld.AngerLoveHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Constantly enraged";
                } else if (numberICareAbout == -1)
                {
                    textISay = "Irratable";
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to anger and love";
                } else if (numberICareAbout == 1)
                {
                    textISay = "Caring";
                } else if (numberICareAbout == 2)
                {
                    textISay = "Loving";
                }
            } else if (whichAmI == 3)
            {
                numberICareAbout = playerVariablesHeld.LonelyOverstimulatedHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Totally alone";
                } else if (numberICareAbout == -1)
                {
                    textISay = "Awkward";
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to contact with others";
                } else if (numberICareAbout == 1)
                {
                    textISay = "A socialite";
                } else if (numberICareAbout == 2)
                {
                    textISay = "Always talking";
                }
            } else if (whichAmI == 4)
            {
                numberICareAbout = playerVariablesHeld.FearConfidenceHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Terrified";
                } else if (numberICareAbout == -1)
                {
                    textISay = "Easy to frighten";
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to fear and confidence";
                } else if (numberICareAbout == 1)
                {
                    textISay = "Confident";
                } else if (numberICareAbout == 2)
                {
                    textISay = "Smug";
                }
            }
        }

        if (textISay != null)
        {
            thisText.text = textISay;
        }
    }
}
