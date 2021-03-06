using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boolet : MonoBehaviour
{
    private Rigidbody rb;
    private Collider col;
    private TrailRenderer trail;
    private MeshRenderer mesh;
    private GameObject parts;
    public GameObject bloodSplurt;
    public GameObject burst;
    private float speed = 25;
    private bool exists = true;
    private AudioSource src;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
        col = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        mesh = GetComponent<MeshRenderer>();
        parts = transform.Find("SparksEffect").gameObject;
        trail = transform.Find("Trail").GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (exists)
            rb.velocity = transform.up * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("obstacle") || collision.gameObject.CompareTag("cube") || collision.gameObject.CompareTag("shelf") || collision.gameObject.CompareTag("fakewall"))
        {
            src.Play();
            mesh.enabled = false;
            col.enabled = false;
            rb.velocity = Vector3.zero;
            parts.SetActive(false);
            GameObject burstTemp = Instantiate(burst, transform.position, transform.rotation);
            Destroy(burstTemp, 1.5f);
            exists = false;
            trail.time = 9999;
            StartCoroutine(FadeTrail());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            print("hi");
            mesh.enabled = false;
            col.enabled = false;
            rb.velocity = Vector3.zero;
            parts.SetActive(false);
            GameObject burstTemp = Instantiate(burst, transform.position, transform.rotation);
            Destroy(burstTemp, 1.5f);
            exists = false;
            trail.time = 9999;
            StartCoroutine(FadeTrail());
            Instantiate(bloodSplurt, transform.position, transform.rotation);
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }
    }

    IEnumerator FadeTrail()
    {
        yield return new WaitForSeconds(0.05f);
        trail.endColor = new Color(trail.endColor.r, trail.endColor.g, trail.endColor.b, trail.endColor.a - 0.1f);
        trail.startColor = new Color(trail.startColor.r, trail.startColor.g, trail.startColor.b, trail.startColor.a - 0.1f);
        if (trail.endColor.a > 0)
            StartCoroutine(FadeTrail());
    }

}
