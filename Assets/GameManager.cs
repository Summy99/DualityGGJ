using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;

    [Header("Grid Values Etc")]
    public List<float> xValues; // List for x values in grid
    public List<float> yValues; // List for y values in grid
    public Vector3[,] grid; //2D array for positions in the grid.
    public int gridsizeX; //19 for this project
    public int gridsizeY; //11 for this project
    public float gridstartX;
    public float gridstartY;
    public GameObject cell;
    public Transform cellGrid;

    [Header("Movement Stuff")]
    public float moveVariX = 2;
    public float moveVariY = 2;

    void Awake()
    {
        if (GM == null)
        {
            //  DontDestroyOnLoad(this); //this means it will exist if you switch scenes.
            GM = this;
        }
        else
        {
            Destroy(gameObject);
        }

        grid = new Vector3[gridsizeX, gridsizeY];

        xValues.Add(gridstartX);
        yValues.Add(gridstartY);

        for (int i = 0; i < gridsizeX; i++)
        {
            xValues.Add(xValues[i] + moveVariX);
        }
        for (int i = 0; i < gridsizeY; i++)
        {
            yValues.Add(yValues[i] - moveVariY);
        }

        for (int y = 0; y < gridsizeY; y++)
        {
            for (int x = 0; x < gridsizeX; x++)
            {
                grid[x, y] = new Vector3(xValues[x], yValues[y], 0);
                Instantiate(cell, grid[x, y], Quaternion.identity, cellGrid);
            }
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        cellGrid.transform.position = new Vector3(cellGrid.transform.position.x, cellGrid.transform.position.y, 71);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
