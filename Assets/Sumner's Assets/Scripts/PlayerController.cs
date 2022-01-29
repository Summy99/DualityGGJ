using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private AnimationState state;
    public GameObject boolet;
    private GameObject cameraRef;

    private GameObject booletSpawned;

    void Start()
    {
        anim = GetComponent<Animator>();
        cameraRef = transform.GetChild(0).gameObject;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        anim.SetTrigger("fire");
        booletSpawned = Instantiate(boolet, transform.GetChild(0).GetChild(0).GetChild(0).position, Quaternion.Euler(cameraRef.transform.rotation.eulerAngles.x + 90, cameraRef.transform.rotation.eulerAngles.y, cameraRef.transform.rotation.eulerAngles.z));
        Destroy(booletSpawned, 10f);
    }
}
