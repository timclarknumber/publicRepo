using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialScript : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    [SerializeField]private RectTransform thisTransform;
    [SerializeField]private float skipX = 0f;
    [SerializeField]private float skipY = 0f;
    [SerializeField]private TutorialTextScript tutorialTextScript;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x > skipX - 0.5)
        {
            Destroy(gameObject);
        }

        if (playerTransform.position.x <= 5)
        {
            tutorialTextScript.changeTextTo("Welcome to EEMotion! WASD to move.");
        } else if (playerTransform.position.x > 5 && playerTransform.position.x < 10)
        {
            tutorialTextScript.changeTextTo("On the map, you will see green tiles, like this. Step on them to unlock abilities.");
        } else if (playerTransform.position.x > 10 && playerTransform.position.x < 15)
        {
            tutorialTextScript.changeTextTo("Abilities to do what? Fight! How? Step on red tiles like this one to fight enemies.");
        } else if (playerTransform.position.x > 15 && playerTransform.position.x < 20)
        {
            tutorialTextScript.changeTextTo("In combat, your abilities will affect the emotional states you see at the bottom of the screen.");
        } else if (playerTransform.position.x > 20 && playerTransform.position.x < 25)
        {
            tutorialTextScript.changeTextTo("What do emotions effect? The emotional states at the bottom of the screen will sometimes restrict the abilities you can unlock.");
        } else if (playerTransform.position.x > 25)
        {
            tutorialTextScript.changeTextTo("Kill all the enemies! Don't die. Unlock abilities. Manage your emotions.");
        }
    }

    public void skipTutorial()
    {
        playerTransform.position = new Vector3(skipX, skipY, 0f);
    }
}
