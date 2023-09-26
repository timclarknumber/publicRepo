using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CustomerTextLocal : MonoBehaviour
{//this script updates the text attached under a customer to match its demand value
    [SerializeField] private CustomerPickupTrigger demandHolder;
    [SerializeField] private TMP_Text demandText; 

    // Update is called once per frame
    void Update()
    {
        demandText.text = demandHolder.neededPizzas.ToString();
    }
}
