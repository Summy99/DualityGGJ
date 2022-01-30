using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int ammo = 50;

    private Animator anim;
    private Collider col;
    private AnimationState state;
    public GameObject boolet;
    private GameObject cameraRef;
    public GameObject muzzleFlash;
    private GameController gc;

    private GameObject booletSpawned;
    private GameObject flashTemp;

    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        col = GetComponent<Collider>();
        anim = GetComponent<Animator>();
        cameraRef = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammo > 0)
        {
            Shoot();
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "ammo")
        {
            ammo += 10;
            Destroy(other.gameObject);
        }

        if (other.name == "HP")
        {
            GetComponent<PlayerHealth>().health += 10;
            Destroy(other.gameObject);
        }
    }

    private void Shoot()
    {
        if (!gc.twod)
        {
            ammo--;
            anim.SetTrigger("fire");
            booletSpawned = Instantiate(boolet, transform.GetChild(0).GetChild(0).GetChild(0).position, Quaternion.Euler(cameraRef.transform.rotation.eulerAngles.x + 90, cameraRef.transform.rotation.eulerAngles.y, cameraRef.transform.rotation.eulerAngles.z));
            Destroy(booletSpawned, 10f);
            flashTemp = Instantiate(muzzleFlash, transform.GetChild(0).GetChild(0).GetChild(0));
            Destroy(flashTemp, 1);
        }
        else
        {
            ammo--;
            anim.SetTrigger("fire");
            flashTemp = Instantiate(muzzleFlash, transform.GetChild(0).GetChild(0).GetChild(0));
            Destroy(flashTemp, 1);
            booletSpawned = Instantiate(boolet, transform.GetChild(0).GetChild(0).GetChild(0).position, Quaternion.Euler(transform.rotation.eulerAngles.x + 90, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
            Destroy(booletSpawned, 10f);
        }
    }
}
