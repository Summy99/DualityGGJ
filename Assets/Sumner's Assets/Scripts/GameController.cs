using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour
{
    public bool twod = false;
    public TextMeshProUGUI ammocount;
    public TextMeshProUGUI healthcount;
    public GameObject fpsCam;
    public GameObject gunCam;
    public GameObject orthoCam;
    private GameObject[] shelves;
    private GameObject[] cubes;
    private GameObject[] fakewalls;
    private AudioSource src;
    public AudioClip twodtothreed;
    public AudioClip threedtotwod;

    public Image threedCrosshair;
    public Image twodCrosshair;

    public RigidbodyFirstPersonController pl;
    public PlayerController pc;
    public EnemyAiTutorial eait;

    public Movement2D twodmove;
    public MouseFollow mf;

    public GameObject cinemachineCam;
    // Start is called before the first frame update
    void Start()
    {
        src = pl.gameObject.GetComponent<AudioSource>();
        shelves = GameObject.FindGameObjectsWithTag("shelf");
        cubes = GameObject.FindGameObjectsWithTag("cube");
        fakewalls = GameObject.FindGameObjectsWithTag("fakewall");
        foreach (GameObject c in cubes)
            c.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        twodCrosshair.transform.position = Input.mousePosition;
        ammocount.text = pl.gameObject.GetComponent<PlayerController>().ammo.ToString();
        healthcount.text = pl.gameObject.GetComponent<PlayerHealth>().health.ToString() + "/" + pl.gameObject.GetComponent<PlayerHealth>().maxhealth.ToString();
    }

    public void johnswitch()
    {
        cinemachineCam.GetComponent<Camera>().enabled = true;

        pl.enabled = false;
        pc.enabled = false;
        if(GameObject.FindGameObjectsWithTag("enemy").Length > 1)
            eait.enabled = false;



        if (twod)
        {
            src.clip = twodtothreed;
            src.Stop();
            src.PlayDelayed(1);
            twodCrosshair.enabled = false;
            pl.gameObject.transform.Find("firesfx").gameObject.GetComponent<AudioSource>().volume = 1;
            //fpsCam.GetComponent<Camera>().enabled = true;
            //gunCam.GetComponent<Camera>().enabled = true;
            orthoCam.SetActive(false);
        }
        else
        {
            src.clip = threedtotwod;
            src.Stop();
            src.PlayDelayed(2);
            threedCrosshair.enabled = false;
            pl.gameObject.transform.Find("firesfx").gameObject.GetComponent<AudioSource>().volume = 0.5f;
            fpsCam.GetComponent<Camera>().enabled = false;
            gunCam.GetComponent<Camera>().enabled = false;
            //orthoCam.SetActive(true);
        }
    }
    public void Switch()
    {
        cinemachineCam.GetComponent<Camera>().enabled = false;

        pl.enabled = true;
        pc.enabled = true;
        if (GameObject.FindGameObjectsWithTag("enemy").Length > 1)
            eait.enabled = true;


        if (twod)
        {
            threedCrosshair.enabled = true;
            twod = false;
            pl.mouseLook.SetCursorLock(true);
            foreach (GameObject f in fakewalls)
                f.GetComponent<Collider>().enabled = true;
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
            twodCrosshair.enabled = true;
            twodCrosshair.enabled = true;
            pl.mouseLook.SetCursorLock(false);
            foreach (GameObject f in fakewalls)
                f.GetComponent<Collider>().enabled = false;
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
