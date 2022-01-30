﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public int maxhealth = 100;

    void Start()
    {
        
    }

    void Update()
    {
        if (health > maxhealth)
            health = maxhealth;
    }

    public void DamagePlayer(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        print("you died");
    }
}
