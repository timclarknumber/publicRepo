using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoseHealth(float damage)
    {
        rectTransform.offsetMax = new Vector2(-damage, -478.4684f); //this is changing the stretch right and top values of the panel in the editor, top 10 worst and least intuitive names for things in the unity editor.
        //This also works *perfectly* without me even remembering that oh yeah normally anything to do with the UI needs an include at the start for the UI stuff. Bot this varable, somehow.
    }
}
