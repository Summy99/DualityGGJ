using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    private AudioSource src;
    public AudioClip splat;
    public GameObject bloodSplat;

    private void Start()
    {
        src = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        src.PlayOneShot(splat);
        Instantiate(bloodSplat,transform.position, Quaternion.identity);
    }
}
