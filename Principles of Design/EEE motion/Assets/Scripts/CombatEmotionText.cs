using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatEmotionText : MonoBehaviour
{
    public TextMeshProUGUI sadJoyText;
    public TextMeshProUGUI angerLoveText;
    public TextMeshProUGUI lonelyOverstimulatedText;
    public TextMeshProUGUI fearConfidenceText;
    [SerializeField]private GameObject playerVariableHolder;
    [SerializeField]private PlayerVariablesHeld emotions; //I'm copying a script i made previously so im just gonna refer to it the same way, but it is actually talking to another script

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("PlayerVariableHolder") != null) //is there a player?
        {
            playerVariableHolder = GameObject.Find("PlayerVariableHolder");
            emotions = playerVariableHolder.GetComponent<PlayerVariablesHeld>();
        }
        if (playerVariableHolder != null)
        {
            sadJoyText.text = emotions.SadJoyHeld.ToString();
            angerLoveText.text = emotions.AngerLoveHeld.ToString();
            lonelyOverstimulatedText.text = emotions.LonelyOverstimulatedHeld.ToString();
            fearConfidenceText.text = emotions.FearConfidenceHeld.ToString();
        }
    }
}