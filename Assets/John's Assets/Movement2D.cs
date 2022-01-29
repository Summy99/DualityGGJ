using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Vector2 velocity;
    public float speed;
    public Rigidbody2D rb;

    public Vector2 crying;

    public Vector2 mousePos;

    public Camera cam;

    public bool dead;

    public Vector3 lookDir;

    public SpriteRenderer sprite;
    public SpriteRenderer swordSprite;

    // Start is called before the first frame update
    void Start()
    {
        dead = false;
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        crying.x = transform.position.x;
        crying.y = transform.position.y;
        if (!dead)
        {
            velocity.x = Input.GetAxisRaw("Horizontal");// * speed;
            velocity.y = Input.GetAxisRaw("Vertical");// * speed;

            velocity = Vector3.Normalize(velocity);
            velocity *= speed;

            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos.x > transform.localPosition.x)
            {
                sprite.flipY = false;
                swordSprite.flipY = false;
            }
            else
            {
                sprite.flipY = true;
                swordSprite.flipY = true;
            }



            rb.MovePosition(crying + velocity * Time.deltaTime);

            lookDir = mousePos - rb.position;

            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
        }


    }
}
