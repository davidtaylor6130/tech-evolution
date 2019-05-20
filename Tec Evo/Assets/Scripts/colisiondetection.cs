using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisiondetection : MonoBehaviour {

    public GameObject GameOBJMoved;
    public GameObject Unlocks;


    string cloneAdditon;
    bool OverObject;

	void OnTriggerEnter2D(Collider2D other)
    {
        cloneAdditon = GameOBJMoved.name + "(Clone)";
        if (other.name == cloneAdditon)
        {
            Debug.Log("over");
            OverObject = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == cloneAdditon)
        {
            Debug.Log("Not Over");
            OverObject = false;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (OverObject == true && Input.GetMouseButtonDown(0) == true)
        {
            Debug.Log("clicked when over ");
            Unlocks.SetActive(true);
        }
	}
}
