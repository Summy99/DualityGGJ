using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Messages : MonoBehaviour
{
    public TextMeshProUGUI message;

    void Start()
    {
        StartCoroutine(TextIntro());
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            StartCoroutine(TextStageTwo());

    }

    IEnumerator TextIntro()
    {
        message.text = "Blaze Man! It's me, Gun Lad!";
        yield return new WaitForSeconds(3);
        message.text = "We've finally found the location of the GOLDEN SHADES!";
        yield return new WaitForSeconds(3);
        message.text = "They should be around here somewhere...";
        yield return new WaitForSeconds(3);
        message.text = "Hmm, one of these walls looks fishy, try pressing E to get a new perspective on the situation";
    }

    IEnumerator TextStageTwo()
    {
        yield return new WaitForSeconds(3);
        message.text = "I knew it! But be careful, there's bound to be water imps around.";
        yield return new WaitForSeconds(5);
        message.text = "";
    }

}
