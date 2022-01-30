using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet : MonoBehaviour
{
    public GameObject player;
    private GameController gc;
    public Rigidbody rb;
   // public GameObject devil;
    public float speed = 25f;

    private void Awake()
    {
       player = GameObject.FindGameObjectWithTag("Player");
       gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    // Start is called before the first frame update
    void Start()
    { 

        rb = GetComponent<Rigidbody>();
        if (!gc.twod)
            transform.LookAt(player.transform);
        else
        {
            Vector3 target = player.transform.position;
            Vector3 direction = target - transform.position;
            float rotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, rotation, 0);
        }
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

        if (collision.gameObject.CompareTag("obstacle") || collision.gameObject.CompareTag("cube") || collision.gameObject.CompareTag("fakewall"));
        {
            Destroy(gameObject);
        }
    }
}
