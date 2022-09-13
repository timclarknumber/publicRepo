using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public string sceneName;
    public float timeLeft = 300; //this is how much time is left but it can be changed in editor
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = UnityEngine.Mathf.Round(timeLeft).ToString(); //round the current time because the time is a float and that many decimal places is ugly as UI
        timeLeft -= Time.deltaTime; //count down the time using actual time

        if (timeLeft < 0) //if there isnt any time left...
        {
            SceneManager.LoadScene(sceneName); //go to the specified scene, in this case, usually the Lose scene
            Destroy(gameObject); //destroy this object
        }
    }
}
