using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    private AudioSource src;
    public AudioClip sizzle, death;

    public int health = 100;
    public int maxhealth = 100;

    void Start()
    {
        src = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (health > maxhealth)
            health = maxhealth;
    }

    public void DamagePlayer(int damage)
    {
        src.PlayOneShot(sizzle);
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        transform.Find("music").gameObject.SetActive(false);
        src.PlayOneShot(death);
        print("you died");
        SceneManager.LoadScene(2);
    }
}
