using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class funnavmeshactivities : MonoBehaviour
{

    public GameObject flyFloor;
    public NavMeshSurface nav3D;
    public NavMeshSurface nav2D;

    // Start is called before the first frame update
    void Start()
    {


        flyFloor.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            nav3D.enabled = !nav3D.isActiveAndEnabled;
            nav2D.enabled = !nav2D.isActiveAndEnabled;
            print("yeah it's workin bitch you got a problem with it?");
        }
    }
}
