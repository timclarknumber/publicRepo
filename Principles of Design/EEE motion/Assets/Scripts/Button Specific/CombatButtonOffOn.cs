using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatButtonOffOn : MonoBehaviour
{
    [SerializeField]private RectTransform thisTransform;
    [SerializeField]private string whatUnlocksMe;
    [SerializeField]private float whereIGoY = -120f;
    [SerializeField]private float whereIGoX = 340f;
    // Update is called once per frame

    void Start()
    {
        thisTransform.anchoredPosition = new Vector2(1000f, -5000f);
    }

    void Update()
    {
        if (GameObject.Find(whatUnlocksMe) != null) //if i am unlocked
        {
            thisTransform.anchoredPosition = new Vector2(whereIGoX, whereIGoY); //let the player access me
        }
    }
}
