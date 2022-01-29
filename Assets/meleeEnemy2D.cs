using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemy2D : MonoBehaviour
{
    public bool chase;
    //public Rigidbody2D rb;
    public GameObject player;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chase)
        {
          transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.01f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("sword"))
        {
            Destroy(gameObject);
        }
    }
}
