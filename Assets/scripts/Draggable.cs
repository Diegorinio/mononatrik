using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    bool isheld = false;
    public Vector3 space;



    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            isheld = true;
            Vector3 pos = GetMousePos();
            pos.z = transform.position.z;
            space = transform.position - pos;
        }
    }

    private void OnMouseUp()
    {
        isheld = false;
    }

    private void Update()
    {
        if (isheld)
        {
            Vector3 pos = GetMousePos() + space;
            //Nie wypierdalaj w osi z
            pos.z = transform.position.z;
            transform.position = pos;
        }
    }

    private Vector3 GetMousePos()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(pos);
    }
}
