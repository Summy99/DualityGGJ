﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class menuOn : MonoBehaviour
{
    public Transform vmCam;
    public Camera turnoff;
    public Camera turnon;
    public GameObject mainmenuCanvas;
    public void menuTurnOn()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<RigidbodyFirstPersonController>().mouseLook.lockCursor = false;

        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            turnoff.enabled = false;
            turnon.enabled = true;
            mainmenuCanvas.SetActive(true);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            mainmenuCanvas.SetActive(true);
        }


       // transform.position = vmCam.position;
       //  transform.rotation = vmCam.rotation;
        print("eyyo this script be workin dog");
    }
}
