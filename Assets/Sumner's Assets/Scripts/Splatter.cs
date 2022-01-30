using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    private AudioSource src;
    public GameObject smoke;
    public GameObject bloodSplat;

    private bool burning = false;

    private void Start()
    {
        src = GetComponent<AudioSource>();
        burning = true;
        Instantiate(smoke, transform.position, Quaternion.Euler(-90, 0, 0), transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        src.Play();
        Instantiate(bloodSplat,transform.position, Quaternion.identity);
    }
}
