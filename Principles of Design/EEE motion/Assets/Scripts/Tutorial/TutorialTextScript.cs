using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialTextScript : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI thisText;
    // Start is called before the first frame update

    
    public void changeTextTo(string newText)
    {
        thisText.text = newText;
    }
}
