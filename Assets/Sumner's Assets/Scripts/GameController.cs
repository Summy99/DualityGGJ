﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour
{
    public bool twod = false;
    public GameObject fpsCam;
    public GameObject gunCam;
    public GameObject orthoCam;

    public RigidbodyFirstPersonController pl;
    public Movement2D twodmove;
    public MouseFollow mf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }
    }

    private void Switch()
    {
        if(twod)
        {
            twod = false;
            pl.enabled = true;
            pl.mouseLook.SetCursorLock(true);
            mf.enabled = false;
            twodmove.enabled = false;
            fpsCam.GetComponent<Camera>().enabled = true;
            gunCam.GetComponent<Camera>().enabled = true;
            orthoCam.SetActive(false);
        }
        else
        {
            pl.mouseLook.SetCursorLock(false);
            twod = true;
            pl.enabled = false;
            mf.enabled = true;
            twodmove.enabled = true;
            fpsCam.GetComponent<Camera>().enabled = false;
            gunCam.GetComponent<Camera>().enabled = false;
            orthoCam.SetActive(true);
        }
    }
}
