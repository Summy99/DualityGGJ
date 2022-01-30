using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Die();
        }
    }
}
