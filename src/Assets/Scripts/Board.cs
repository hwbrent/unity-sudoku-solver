using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    // Set in the Unity editor.
    // We do this so that we can dynamically create instances of the Cell
    // class.
    public GameObject cell;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(this.cell);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
