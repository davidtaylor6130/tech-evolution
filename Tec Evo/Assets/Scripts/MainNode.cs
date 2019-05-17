 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainNode : MonoBehaviour {

    public GameObject GameOBJ;

	private void OnMouseDown()
    {
        Instantiate(GameOBJ);
    }
}
