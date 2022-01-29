using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMovement : MonoBehaviour
{
    private float scaleX = 0;
    private float scaleY = 0;
    private float scaleZ = 0;

    private float rotationX = 0;
    private float rotationY = 0;
    private float rotationZ = 0;

    private float positionX = 0;
    private float positionY = 0;
    private float positionZ = 0;

    private float hover = 0;

    public float growFactor = 0.1f;
    public float spinFactor = 0.1f;
    public float hoverFactor = 0.1f;

    public int itemIndex = 0;

    void Start()
    {       
        scaleX = 0;
        scaleY = 0;
        scaleZ = 0;

        rotationX = 0;
        rotationY = 0;
        rotationZ = 0;

        positionX = 0;
        positionY = 0;
        positionZ = 0;

        hover = 0;
    }

    void Update()
    {
        gameObject.transform.localPosition = new Vector3(positionX, positionY, positionZ);
        //gameObject.transform.localScale = new Vector3(scaleX, scaleY, scaleZ);
        gameObject.transform.rotation = Quaternion.Euler(rotationX, rotationY, rotationZ);
    }

    void FixedUpdate()
    {
       // if(scaleX < 1)
        //{
           // Grow();
        //}

        Spin();

        Hover();
    }

    void Grow()
    {
        scaleX += growFactor;
        scaleY += growFactor;
        scaleZ += growFactor;
    }

    void Spin()
    {
        rotationY += spinFactor;
    }

    void Hover()
    {
        positionY += (Mathf.Sin(hover) * 0.01f);

        hover += hoverFactor;
    }
}
