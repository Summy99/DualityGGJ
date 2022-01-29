using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devilAttack : MonoBehaviour
{
    public bool attack;
    public GameObject player;
    private GameController gc;

    public GameObject wateroot;

    public float timer;
    public float timerOG;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        timer = timerOG;
    }

    // Update is called once per frame
    void Update()
    {
        if (attack)
        {
            if(timer <= 0)
            {
                GameObject go = Instantiate(wateroot, transform.position, transform.rotation);
                go.GetComponent<enemyBullet>().player = player;
                //go.GetComponent<enemyBullet>().devil = gameObject;
                timer = timerOG;
            }
            else
            {
                timer -= Time.deltaTime;
            }

            if(!gc.twod)
                transform.LookAt(player.transform);
            else
            {
                Vector3 target = player.transform.position;
                Vector3 direction = target - transform.position;
                float rotation = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0, rotation, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject;
            attack = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            attack = false;
            // transform.LookAt(collision.gameObject.transform);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
