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
        player = GameObject.FindGameObjectWithTag("Player");
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
}
