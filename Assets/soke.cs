using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soke : MonoBehaviour
{
    Quaternion tr;
    void Start()
    {
        tr = transform.rotation;
    }

    void Update()
    {
        transform.rotation = tr;
    }
}
