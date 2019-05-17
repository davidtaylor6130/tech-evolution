using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickDrag : MonoBehaviour {

    bool mouseDown;
    public GameObject GameObjSelf;

    void start()
    {
        mouseDown = true;
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonDown(0) == false)
        {



            mouseDown = false;
            Destroy(GameObjSelf);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDown = true;
        }

        if (mouseDown == true)
        {
            Vector2 mPosition = new Vector2 (Input.mousePosition.x,Input.mousePosition.y);
            Vector2 mObj = Camera.main.ScreenToWorldPoint(mPosition);
            transform.position = mObj;
        }
    }

    void OnMouseDrag()
    {
    }
}
