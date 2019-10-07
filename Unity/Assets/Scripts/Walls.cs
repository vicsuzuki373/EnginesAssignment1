using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private float time = 0.3f;

    void Update()
    {
        if (time < 0.3f)
            time += Time.deltaTime;
    }

    void OnMouseOver()
    {
        if (!GameManagerScript.isPlaying)
        {
            if (Input.GetKey("r") && time > 0.25f)
            {
                transform.Rotate(new Vector3(0f, 90f, 0f));
                time = 0.0f;
            }
            if (Input.GetKey("x"))
            {
                Destroy(gameObject);
            }
        }
    }

}
