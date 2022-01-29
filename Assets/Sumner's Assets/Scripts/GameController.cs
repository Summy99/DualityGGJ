using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour
{
    public bool twod = false;
    public TextMeshProUGUI ammocount;
    public GameObject fpsCam;
    public GameObject gunCam;
    public GameObject orthoCam;
    private GameObject[] shelves;
    private GameObject[] cubes;

    public RigidbodyFirstPersonController pl;
    public Movement2D twodmove;
    public MouseFollow mf;
    // Start is called before the first frame update
    void Start()
    {
        shelves = GameObject.FindGameObjectsWithTag("shelf");
        cubes = GameObject.FindGameObjectsWithTag("cube");
        foreach (GameObject c in cubes)
            c.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Switch();
        }

        ammocount.text = pl.gameObject.GetComponent<PlayerController>().ammo.ToString();
    }

    private void Switch()
    {
        if(twod)
        {
            twod = false;
            pl.mouseLook.SetCursorLock(true);
            mf.enabled = false;
            //twodmove.enabled = false;
            fpsCam.GetComponent<Camera>().enabled = true;
            gunCam.GetComponent<Camera>().enabled = true;
            orthoCam.SetActive(false);
            foreach (GameObject c in cubes)
                c.SetActive(false);
        }
        else
        {
            pl.mouseLook.SetCursorLock(false);
            twod = true;
            mf.enabled = true;
            //twodmove.enabled = true;
            fpsCam.transform.rotation = Quaternion.Euler(new Vector3(0, fpsCam.transform.rotation.eulerAngles.y, fpsCam.transform.rotation.eulerAngles.z));
            fpsCam.GetComponent<Camera>().enabled = false;
            gunCam.GetComponent<Camera>().enabled = false;
            orthoCam.SetActive(true);
            foreach (GameObject c in cubes)
                c.SetActive(true);
        }
    }
}
