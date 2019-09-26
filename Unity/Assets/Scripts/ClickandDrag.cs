using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickandDrag : MonoBehaviour
{
    private bool isMouseOver = false;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        isMouseOver = true;
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        if (isMouseOver)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(transform.position.x, 5.0f, transform.position.z);
        }
    }

    void OnMouseUp()
    {
        isMouseOver = false;
    }
}
