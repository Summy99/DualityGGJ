using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int ammo = 50;

    private Animator anim;
    private AnimationState state;
    public GameObject boolet;
    private GameObject cameraRef;
    public GameObject muzzleFlash;

    private GameObject booletSpawned;
    private GameObject flashTemp;

    void Start()
    {
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

    private void Shoot()
    {
        ammo--;
        anim.SetTrigger("fire");
        booletSpawned = Instantiate(boolet, transform.GetChild(0).GetChild(0).GetChild(0).position, Quaternion.Euler(cameraRef.transform.rotation.eulerAngles.x + 90, cameraRef.transform.rotation.eulerAngles.y, cameraRef.transform.rotation.eulerAngles.z));
        Destroy(booletSpawned, 10f);
        flashTemp = Instantiate(muzzleFlash, transform.GetChild(0).GetChild(0).GetChild(0));
        Destroy(flashTemp, 1);
    }
}
