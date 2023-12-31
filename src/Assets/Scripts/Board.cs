using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Set in the Unity editor.
    // We do this so that we can dynamically create instances of the Cell
    // class.
    public GameObject cellPrefab;

    private List<GameObject> cells;

    // Start is called before the first frame update
    void Start()
    {
        this.cells = new List<GameObject>();

        int rows = 9;
        int columns = 9;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                var cell = Instantiate(this.cellPrefab);

                this.cells.Add(cell);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
