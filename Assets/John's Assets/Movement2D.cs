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

    public GameObject swordRotato;
    public Animator swordSwing;

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
        if (Input.GetMouseButtonDown(0))
        {
            swordSwing.SetBool("Studio Boolean", true);
            //swordSwing.SetBool("Studio Boolean", !swordSwing.GetBool("Studio Boolean"));
            //swordRotato.transform.SetPositionAndRotation(swordRotato.transform.position, new Quaternion(0, 0, 90, 90));
            //StartCoroutine(swordSwing(1, 2));
        }


    }
    

        
   /* IEnumerator swordSwing(float aValue, float aTime)
    {
        swordRotato.transform.SetPositionAndRotation(swordRotato.transform.position, new Quaternion(0, 0, 90, 90));
        print(swordRotato.transform.rotation.z);
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / aTime)
        {
            swordRotato.transform.Rotate(0, 0, -1);
            //print(swordRotato.transform.rotation.z);
            if (swordRotato.transform.rotation.eulerAngles.z >= new Quaternion(0, 0, 270, -270).eulerAngles.z)
            {
              //  swordRotato.transform.Rotate(0, 0, -90);
                print("anything it doesnt matter");
                break;
            }
            yield return null;
        }
       

        
       // return null;
    }*/



}
