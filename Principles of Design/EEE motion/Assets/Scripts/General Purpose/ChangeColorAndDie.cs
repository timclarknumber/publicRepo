using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeColorAndDie : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI thisText;
    [SerializeField]private float shrinkRate = 5f;
    private float red;
    private float green;
    private float blue;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ExperienceCanvas") != null) //is there a UI canvas?
        {
            thisText.transform.parent = GameObject.Find("ExperienceCanvas").transform;
        }
        red = Random.Range(0f, 255f);
        green = Random.Range(0f, 255f);
        blue = Random.Range(0f, 255f);
        thisText.fontSize -= shrinkRate * Time.deltaTime;
        thisText.color = new Color32((byte) red, (byte) green, (byte) blue, 255);
        if (thisText.fontSize <= 1f)
        {
            Destroy(gameObject);
        }
    }
}
