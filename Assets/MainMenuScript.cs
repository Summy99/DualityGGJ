using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
