using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool twod = false;
    public GameObject fpsCam;
    public GameObject orthoCam;
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
            fpsCam.SetActive(true);
            orthoCam.SetActive(false);
        }
        else
        {
            twod = true;
            fpsCam.SetActive(false);
            orthoCam.SetActive(true);
        }
    }
}
