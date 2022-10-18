using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class KillYouText : MonoBehaviour
{
    [SerializeField] private float timeTillLoss;
    [SerializeField] private string sceneName;
    [SerializeField] private TextMeshProUGUI killText; 

    // Update is called once per frame
    void Update()
    {
        killText.SetText("Time left: " + Mathf.Round(timeTillLoss));
        timeTillLoss -= 1 * Time.deltaTime;
        if (timeTillLoss <= 0)
        {
            SceneManager.LoadScene(sceneName); //change the scene to the lose state.
        }
    }
}
