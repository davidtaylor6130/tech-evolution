using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideOnStart : MonoBehaviour {

    // Use this for initialization

    public GameObject SELF;

	void Start () {
        SELF.SetActive(false);
	}
	

}
