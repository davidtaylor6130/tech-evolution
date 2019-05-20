 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainNode : MonoBehaviour {

    public GameObject GameOBJMoving;

	private void OnMouseDown()
    {
        Instantiate(GameOBJMoving);
    }
}
