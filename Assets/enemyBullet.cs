using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public float speed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.LookAt(player.transform);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 2f);
    }
    private void FixedUpdate()
    {
            rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().DamagePlayer(10);
            Destroy(gameObject);
        }
    }
}
