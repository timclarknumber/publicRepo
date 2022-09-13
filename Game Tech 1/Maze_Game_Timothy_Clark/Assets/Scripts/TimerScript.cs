using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public string sceneName;
    public float timeLeft = 300;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = UnityEngine.Mathf.Round(timeLeft).ToString();
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            SceneManager.LoadScene(sceneName);
            Destroy(gameObject); //destroy this object
        }
    }
}
