using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDetect : MonoBehaviour
{

    public GameObject melee;
    public meleeEnemy2D meleeScript;
    // Start is called before the first frame update
    void Start()
    {
        //print(""+GetComponentInParent<GameObject>());
       // melee = GetComponentInParent<GameObject>();
        meleeScript = melee.GetComponent<meleeEnemy2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            meleeScript.player = collision.gameObject;
            meleeScript.chase = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            meleeScript.chase = false;
        }
    }
}
