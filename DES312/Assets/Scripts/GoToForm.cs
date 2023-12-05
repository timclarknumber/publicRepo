using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToForm : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoForm()
    {
       Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSf6Y015vaHNd8rVYn9er-aSNc18w3LcUbtTiYAQdfSlHpk60w/viewform?usp=sf_link");
       Application.Quit();
    }
}
