using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KILLME : MonoBehaviour
{
    public Animator swordSwing;
    private void Start()
    {
        swordSwing = GetComponent<Animator>();
    }
    public void endSwing() //USED BY ANIMATOR
    {
        swordSwing.SetBool("Studio Boolean", false);
    }
}
