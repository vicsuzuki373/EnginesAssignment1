using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    private bool mouseClicked = false;

    void OnMouseDown()
    {
        mouseClicked = true;
    }

    void OnMouseDrag()
    {
        if (!GameManagerScript.isPlaying)
        {
            if (mouseClicked)
            {
                float yPos = transform.position.y;
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
            }
        }
    }

    void OnMouseUp()
    {
        mouseClicked = false;
    }
}
