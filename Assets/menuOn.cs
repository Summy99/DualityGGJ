using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuOn : MonoBehaviour
{
    public Transform vmCam;
    public Camera turnoff;
    public Camera turnon;
    public GameObject mainmenuCanvas;
    public void menuTurnOn()
    {
        turnoff.enabled = false;
        turnon.enabled = true;
        mainmenuCanvas.SetActive(true);

       // transform.position = vmCam.position;
       //  transform.rotation = vmCam.rotation;
        print("eyyo this script be workin dog");
    }
}
