using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNodes : MonoBehaviour {

    public GameObject nodesMaster;
    public Vector3 maxLeft;
    public Vector3 maxRight;
    public float MoveLeftAndRight;

    bool HasBeenMoved;
    int ammountMoved = 0;

    void OnMouseOver()
    {
        Debug.Log("over");

        if (Input.GetMouseButton(0) == true)
        {
            if (HasBeenMoved == false)
            {

                if (MoveLeftAndRight < 0 && nodesMaster.transform.position != maxLeft ) { Move(); };
                if (MoveLeftAndRight > 0 && nodesMaster.transform.position != maxRight ) { Move(); };

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
        for (int i = 0; i < 3; i++)
        {
                nodesMaster.transform.position += new Vector3(MoveLeftAndRight, 0, 0);
        }
    }
}
