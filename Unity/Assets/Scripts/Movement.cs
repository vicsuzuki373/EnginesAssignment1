using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    private Vector3 pos = new Vector3(0f,0f,0f);
    public float speed = 10.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            pos.z += speed;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed;
        }

        player.AddForce(pos,ForceMode.VelocityChange);
        pos = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
