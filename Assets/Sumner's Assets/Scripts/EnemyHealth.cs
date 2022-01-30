using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 5;
    public GameObject exp;
    public GameObject[] gibs = new GameObject[9];

    private AudioSource src;

    public AudioClip[] hit;
    public AudioClip death;

    // Start is called before the first frame update
    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;

        src.PlayOneShot(hit[Random.Range(0, hit.Length - 1)]);

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        src.PlayOneShot(death);
        int[] gibsToSpawn = new int[5];

        for (int i = 0; i < gibsToSpawn.Length; i++)
            gibsToSpawn[i] = Random.Range(0, 8);

        foreach(int i in gibsToSpawn)
        {
            GameObject gib = Instantiate(gibs[i], transform.position, Random.rotation);

            gib.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0.5f, 3), Random.Range(0.5f, 3), Random.Range(0.5f, 3)), ForceMode.Impulse);
        }

        transform.parent.Find("polySurface1").GetComponent<SkinnedMeshRenderer>().enabled = false;
        transform.parent.GetComponent<EnemyAiTutorial>().enabled = false;
        Collider[] cols = GetComponents<Collider>();
        foreach (Collider c in cols)
            c.enabled = false;

        Instantiate(exp, transform.position, transform.rotation);
        Destroy(transform.parent.gameObject, 2f);
    }
}
