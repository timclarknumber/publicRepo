using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmotionText : MonoBehaviour
{
    public TextMeshProUGUI sadJoyText;
    public TextMeshProUGUI angerLoveText;
    public TextMeshProUGUI lonelyOverstimulatedText;
    public TextMeshProUGUI fearConfidenceText;
    public Emotions emotions;
    

    // Update is called once per frame
    void Update()
    {
        sadJoyText.text = emotions.SadJoy.ToString();
        angerLoveText.text = emotions.AngerLove.ToString();
        lonelyOverstimulatedText.text = emotions.LonelyOverstimulated.ToString();
        fearConfidenceText.text = emotions.FearConfidence.ToString();
    }
}
