using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNodes : MonoBehaviour {

    //Array to store all the node places on
    GameObject[] array = new GameObject[7];

    public GameObject Nodes; 
    public GameObject NodesOne;
    public GameObject NodesTwo;
    public GameObject NodesThree;
    public GameObject NodesFour;
    public GameObject NodesFive;
    public GameObject NodesSix;
    public float MoveLeftAndRight;
    public int StartingPosition;

    bool HasBeenMoved;
    int ammountMoved = 0;
	 
    void Start()
    {
        array[0] = Nodes;
        array[1] = NodesOne;
        array[2] = NodesTwo;
        array[3] = NodesThree;
        array[4] = NodesFour;
        array[5] = NodesFive;
        array[6] = NodesSix;
    }

    void OnMouseOver()
    {
        Debug.Log("over");

        if (Input.GetMouseButton(0) == true)
        {
            if (HasBeenMoved == false)
            {
                Move();
                HasBeenMoved = true;
            }
        }

        if (Input.GetMouseButton(0) == false && HasBeenMoved == true)
        {
            HasBeenMoved = false;
        }

    }

    void Move()
    {
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(i);
            if (array[i].transform.localPosition.x > 0)
            {
                ammountMoved++;
            }
            else if (array[i].transform.localPosition.x > 0)
            {
                ammountMoved--;
            }

            array[i].transform.localPosition += new Vector3(MoveLeftAndRight, 0, 0);
        }
    }
}
