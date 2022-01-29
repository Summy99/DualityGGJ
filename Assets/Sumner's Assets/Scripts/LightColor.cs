using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColor : MonoBehaviour
{
    private Light sun;

    public float hue = 0f;
    private string change = "up";

    public float roc = 0.1f;

    void Start()
    {
        sun = GameObject.FindGameObjectWithTag("Sun").GetComponent<Light>();
    }

    void FixedUpdate()
    {
        sun.color = Color.HSVToRGB(hue, 0.35f, 1);

        if(hue <= 0)
            change = "up";

        if (hue >= 1)
            change = "down";

        if (change == "down")
            hue -= roc;

        if (change == "up")
            hue += roc;

    }
}
