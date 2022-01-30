using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Cinemachine;
using UnityEngine.Playables;

public class FunnyCameraMovement : MonoBehaviour
{

   public PlayableDirector a3Dto2D;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            a3Dto2D.Play();
        }
    }
}
