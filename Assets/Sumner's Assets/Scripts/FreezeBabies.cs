using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBabies : MonoBehaviour
{
    private Collider[] cols;
    private GameController gc;
    Quaternion origRot;
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        cols = GetComponents<Collider>();
        origRot = transform.rotation;
    }

    void Update()
    {
        if(gc.twod)
        {
            cols[1].enabled = true;
            cols[0].enabled = false;
        }
        else
        {
            cols[1].enabled = false;
            cols[0].enabled = true;
        }
        transform.rotation = origRot;
    }
}
