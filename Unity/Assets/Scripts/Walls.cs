using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private bool playing = GameManagerScript.isPlaying;
    private bool mouseClicked = false;
    private float time = 0.3f;

    void Update()
    {
        if (time < 0.3f)
            time += Time.deltaTime;
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
                transform.position = new Vector3(transform.position.x, 5.0f, transform.position.z);
            }
        }
    }

    void OnMouseUp()
    {
        mouseClicked = false;
    }

    void OnMouseOver()
    {
        if (!playing)
        {
            if (Input.GetKey("r") && time > 0.25f)
            {
                transform.Rotate(new Vector3(0f, 90f, 0f));
                time = 0.0f;
            }
            if (Input.GetKey("x"))
            {
                Destroy(gameObject);
                GameManagerScript.listSize--;
            }
        }
    }

}
