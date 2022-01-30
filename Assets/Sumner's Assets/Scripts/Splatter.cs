using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splatter : MonoBehaviour
{
    public GameObject bloodSplat;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(bloodSplat,transform.position, Quaternion.identity);
    }
}
