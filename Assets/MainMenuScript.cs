﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class MainMenuScript : MonoBehaviour
{
    public GameObject pause;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                pause.SetActive(!pause.activeSelf);
                if (pause.activeSelf)
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<RigidbodyFirstPersonController>().mouseLook.lockCursor = false;
                    Time.timeScale = 0;
                }
                else
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<RigidbodyFirstPersonController>().mouseLook.lockCursor = true;
                    Time.timeScale = 1;
                }
            }
        }
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
    public void quit()
    {
        Application.Quit();
    }
}
