using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    private AudioSource src;
    public GameObject bloodSplat;

    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        src.Play();
        Instantiate(bloodSplat,transform.position, Quaternion.identity);
    }
}
