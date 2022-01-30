using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 5;
    public GameObject exp;
    public GameObject[] gibs = new GameObject[9];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        int[] gibsToSpawn = new int[1];

        for (int i = 0; i < gibsToSpawn.Length; i++)
            gibsToSpawn[i] = Random.Range(0, 8);

        foreach(int i in gibsToSpawn)
        {
            GameObject gib = Instantiate(gibs[i], transform.position, Random.rotation);

            gib.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(10, 20), Random.Range(10, 20), Random.Range(10, 20)), ForceMode.Impulse);
        }

        Instantiate(exp, transform.position, transform.rotation);
        Destroy(transform.parent.gameObject);
    }
}
