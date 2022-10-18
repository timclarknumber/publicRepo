using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialText : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    public TextMeshProUGUI greenText; //frogs
    public TextMeshProUGUI yellowText;
    public TextMeshProUGUI redText; 

    // Update is called once per frame
    void Update()
    {
        if (playerBody.position.x > 23 && playerBody.position.x < 29 && playerBody.position.y < 12)
        {
            greenText.SetText("Press 'I' (as in ian)");
        } else {
            greenText.SetText("");
        }
        if (playerBody.position.x > -11 && playerBody.position.x < -5)
        {
            yellowText.SetText("Press 'J' (as in Jake)");
        } else {
            yellowText.SetText("");
        }
        if (playerBody.position.x > 55 && playerBody.position.x < 60)
        {
            redText.SetText("Press 'N' (as in Norton)");
        } else {
            redText.SetText("");
        }
    }
}
