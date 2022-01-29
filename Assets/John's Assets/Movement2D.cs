using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Vector3 velocity;
    public float speed;
    public Rigidbody rb;

    public bool dead;

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            velocity.x = Input.GetAxisRaw("Horizontal");// * speed;
            velocity.z = Input.GetAxisRaw("Vertical");// * speed;

            velocity = Vector3.Normalize(velocity);
            velocity *= speed;

            rb.MovePosition(transform.position + velocity * Time.deltaTime);
        }


    }
}
