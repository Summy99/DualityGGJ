using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class devilAttack : MonoBehaviour
{
    public bool attack;
    public GameObject player;

    public GameObject wateroot;

    public float timer;
    public float timerOG;
    // Start is called before the first frame update
    void Start()
    {
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
                timer = timerOG;
            }
            else
            {
                timer -= Time.deltaTime;
            }
          
            transform.LookAt(player.transform);
            
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
