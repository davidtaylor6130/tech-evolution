using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour {

    public float Speed;
    Vector3 startPos;
    public float ResetSection;
	
    void Start()
    {
        startPos = transform.position;
    }

	// Update is called once per frame
	void Update ()
    {
        transform.Translate((new Vector3(-1, 0, 0)) * Speed * Time.deltaTime);

        if (transform.position.x < ResetSection)
        {
             transform.position = startPos;
        }
    }
}
