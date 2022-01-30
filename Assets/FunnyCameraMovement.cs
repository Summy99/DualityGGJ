using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Cinemachine;
using UnityEngine.Playables;

public class FunnyCameraMovement : MonoBehaviour
{

   public PlayableDirector a3Dto2D;
    public PlayableDirector a2Dto3D;
    public GameController hahahahhahahah;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (hahahahhahahah.twod)
            {
                a2Dto3D.Play();
            }
            else
            {
                a3Dto2D.Play();
            }
            
        }
    }
}
