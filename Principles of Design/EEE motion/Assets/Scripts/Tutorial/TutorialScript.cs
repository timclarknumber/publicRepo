using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField]private Transform playerTransform;
    [SerializeField]private RectTransform thisTransform;
    [SerializeField]private float skipX = 0f;
    [SerializeField]private float skipY = 0f;

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x > 28)
        {
            Destroy(gameObject);
        }
    }

    public void skipTutorial()
    {
        playerTransform.position = new Vector3(skipX, skipY, 0f);
    }
}
