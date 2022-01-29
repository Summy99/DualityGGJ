using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
   // public GameObject devil;
    public float speed = 25f;

    private void Awake()
    {
       player = GameObject.FindGameObjectWithTag("Player");
       
    }
    // Start is called before the first frame update
    void Start()
    { 

        rb = GetComponent<Rigidbody>();
        transform.LookAt(player.transform);
        //transform.rotation = devil.transform.rotation;
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

        if(collision.gameObject.CompareTag("obstacle") || collision.gameObject.CompareTag("cube"))
        {
            Destroy(gameObject);
        }
    }
}
