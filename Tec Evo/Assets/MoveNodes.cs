using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNodes : MonoBehaviour {

    public GameObject NodeMaster;
    public Vector3 MoveByAmmount;
    public int amountOfTablesEitherWay;
    bool HasBeenMoved;
    float ammountMoved;
	
    void Start()
    {
        ammountMoved = MoveByAmmount.x;
    }

    void OnMouseOver()
    {
        Debug.Log("over");

        if (Input.GetMouseButton(0) == true)
        {
            if (HasBeenMoved == false)
            {
                NodeMaster.transform.position += MoveByAmmount;
                HasBeenMoved = true;
            }
        }

        if (Input.GetMouseButton(0) == false && HasBeenMoved == true)
        {
            HasBeenMoved = false;
        }

    }

}
