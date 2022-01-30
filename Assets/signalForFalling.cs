using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class signalForFalling : MonoBehaviour
{
    public Rigidbody rbGun;
    public Rigidbody rbGlasses;


    public void fall()
    {
        rbGun.useGravity = true;
        rbGlasses.useGravity = true;
    }
}
