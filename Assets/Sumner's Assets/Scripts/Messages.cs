using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Messages : MonoBehaviour
{
    public TextMeshProUGUI message;
    public bool enemydead = false;
    public bool tutcol = false;
    private bool twoplayed = false;
    private bool threeplayed = false;
    private bool fourplayed = false;

    void Start()
    {
        StartCoroutine(TextIntro());
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !twoplayed)
            StartCoroutine(TextStageTwo());

        if (enemydead && !threeplayed)
            StartCoroutine(TextStageThree());

        if (tutcol && !fourplayed)
            StartCoroutine(TextStageFour());
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
        twoplayed = true;
        yield return new WaitForSeconds(3);
        message.text = "I knew it! But be careful, there's bound to be water imps around.";
        yield return new WaitForSeconds(5);
        message.text = "";
    }


    IEnumerator TextStageThree()
    {
        threeplayed = true;
        message.text = "Nice job. It didn't stand a chance.";
        yield return new WaitForSeconds(3);
        message.text = "You should look around this room for some more ammo for me and fuel for you!";
        yield return new WaitForSeconds(3);
        message.text = "";
    }

    IEnumerator TextStageFour()
    {
        fourplayed = true;
        message.text = "Hey I can see the GOLDEN SHADES just across this gap!";
        yield return new WaitForSeconds(3);
        message.text = "But how can you cross it... Oh right!";
        yield return new WaitForSeconds(3);
        message.text = "I forgot to mention it, but these walls are covered in fireproof glue!";
        yield return new WaitForSeconds(3);
        message.text = "Try jumping into one of the walls, but hold on tight!";
        yield return new WaitForSeconds(3);
        message.text = "";
    }
}
