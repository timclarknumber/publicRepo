using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartDisplay : MonoBehaviour
{
    public Image[] heartImages;
    public Sprite[] heartSprites;

    public int currentHealth;

    private void OnValidate()
    {
        currentHealth = Mathf.Max(0, currentHealth);
        UpdateHealth(currentHealth);
    }

    public void UpdateHealth(int currentHealth)
    {
        for (int i = 0; i < heartImages.Length; i++)
        {
            int bottomRange = i * 4;
            int topRange = i * 4 + 4;
            if (currentHealth > topRange)
            {
                //Use full heart (first in array)
                heartImages[i].sprite = heartSprites[heartSprites.Length - 1];
                heartImages[i].enabled = true;
            }
            else if (currentHealth > bottomRange)
            {
                heartImages[i].sprite = heartSprites[currentHealth - bottomRange - 1];
                heartImages[i].enabled = true;
            }
            //else
            //{
                //Use empty heart (last in array)
            //    heartImages[i].sprite = heartSprites[0];
            //    heartImages[i].enabled = false;
            //}
        }
    }
}
