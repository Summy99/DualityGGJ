using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    private AnimationState state;
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("fire");
        }
    }
}
