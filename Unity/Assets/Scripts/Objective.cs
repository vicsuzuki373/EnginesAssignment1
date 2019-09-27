using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{
    private bool playing = GameManagerScript.isPlaying;
    private bool mouseClicked = false;

    void Update()
    {
        playing = GameManagerScript.isPlaying;
    }

    void OnMouseDown()
    {
        mouseClicked = true;
    }

    void OnMouseDrag()
    {
        if (!playing)
        {
            if (mouseClicked)
            {
                transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector3(transform.position.x, 1.0f, transform.position.z);
            }
        }
    }

    void OnMouseUp()
    {
        mouseClicked = false;
    }
}
