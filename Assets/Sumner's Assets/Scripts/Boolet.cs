using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer mesh;
    private GameObject parts;
    private float speed = 25;
    private bool exists = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        parts = transform.Find("SparksEffect").gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(exists)
            rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        mesh.enabled = false;
        parts.SetActive(false);
        exists = false;
    }
}
