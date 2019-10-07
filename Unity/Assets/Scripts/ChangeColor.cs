using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color color1;
    public Color color2;

    // Update is called once per frame
    void Update()
    {
        if (GameManagerScript.isPlaying)
            gameObject.GetComponent<Renderer>().material.color = color1;
        else
            gameObject.GetComponent<Renderer>().material.color = color2;
    }
}
