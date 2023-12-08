using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialUI : MonoBehaviour
{

    //This entire script is not actually used anywhere. It's from a tutorial level that would end up getting replaced.
    public Transform playerTransform;
    public TMP_Text firstToAppear;
    public TMP_Text secondToAppear;
    public TMP_Text thirdToAppear;
    public TMP_Text fourthToAppear;
    public TMP_Text fifthToAppear;
    public TMP_Text sixthToAppear;
    public TMP_Text thisShouldBeAnArraythToAppear;
    [SerializeField] private Color invisibleColor;
    [SerializeField] private Color whiteColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { //this is gross and i hate this, tutorials suck
        if (playerTransform.position.x >= 0 && playerTransform.position.x < 15)
        {
            firstToAppear.color = whiteColor;
        } else {
            firstToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 8 && playerTransform.position.x < 15)
        {
            secondToAppear.color = whiteColor;
        } else {
            secondToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 15)
        {
            thirdToAppear.color = whiteColor;
        } else {
            thirdToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 15)
        {
            fourthToAppear.color = whiteColor;
        } else {
            fourthToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 15)
        {
            fifthToAppear.color = whiteColor;
        } else {
            fifthToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 15)
        {
            sixthToAppear.color = whiteColor;
        } else {
            sixthToAppear.color = invisibleColor;
        }
        if (playerTransform.position.x >= 15)
        {
            thisShouldBeAnArraythToAppear.color = whiteColor;
        } else {
            thisShouldBeAnArraythToAppear.color = invisibleColor;
        }
    }
}
