using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyAfterTime : MonoBehaviour {

    public float Time;
    public GameObject Self;

	// Use this for initialization
	void Start () {
        Object.Destroy(Self,Time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
