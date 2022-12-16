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
                    thisText.color = new Color32(0, 234, 255, 255);
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to sadness and joy";
                    thisText.color = new Color32(0, 0, 0, 255);
                } else if (numberICareAbout == 1)
                {
                    textISay = "Cheery";
                    thisText.color = new Color32(0, 255, 101, 255);
                } else if (numberICareAbout == 2)
                {
                    textISay = "Joyous!";
                    thisText.color = new Color32(24, 255, 0, 255);
                }
            } else if (whichAmI == 2)
            { 
                numberICareAbout = playerVariablesHeld.AngerLoveHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Constantly enraged";
                    thisText.color = new Color32(85, 0, 0, 255);
                } else if (numberICareAbout == -1)
                {
                    textISay = "Irratable";
                    thisText.color = new Color32(200, 0, 0, 255);
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to anger and love";
                    thisText.color = new Color32(0, 0, 0, 255);
                } else if (numberICareAbout == 1)
                {
                    textISay = "Caring";
                    thisText.color = new Color32(255, 0, 75, 255);
                } else if (numberICareAbout == 2)
                {
                    textISay = "Loving";
                    thisText.color = new Color32(255, 0, 180, 255);
                }
            } else if (whichAmI == 3)
            {
                numberICareAbout = playerVariablesHeld.LonelyOverstimulatedHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Totally alone";
                    thisText.color = new Color32(109, 0, 255, 255);
                } else if (numberICareAbout == -1)
                {
                    textISay = "Awkward";
                    thisText.color = new Color32(175, 0, 255, 255);
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to contact with others";
                    thisText.color = new Color32(0, 0, 0, 255);
                } else if (numberICareAbout == 1)
                {
                    textISay = "A socialite";
                    thisText.color = new Color32(206, 0, 255, 255);
                } else if (numberICareAbout == 2)
                {
                    textISay = "Always talking";
                    thisText.color = new Color32(151, 82, 161, 255);
                }
            } else if (whichAmI == 4)
            {
                numberICareAbout = playerVariablesHeld.FearConfidenceHeld;
                if (numberICareAbout == -2)
                {
                    textISay = "Terrified";
                    thisText.color = new Color32(0, 99, 22, 255);
                } else if (numberICareAbout == -1)
                {
                    textISay = "Easy to frighten";
                    thisText.color = new Color32(0, 166, 37, 255);
                } else if (numberICareAbout == 0)
                {
                    textISay = "Apathetic to fear and confidence";
                    thisText.color = new Color32(0, 0, 0, 255);
                } else if (numberICareAbout == 1)
                {
                    textISay = "Confident";
                    thisText.color = new Color32(255, 229, 0, 255);
                } else if (numberICareAbout == 2)
                {
                    textISay = "Smug";
                    thisText.color = new Color32(255, 178, 0, 255);
                }
            }
        }

        if (textISay != null)
        {
            thisText.text = textISay;
        }
    }
}
