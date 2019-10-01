using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    public float speed = 10.0f;

    private bool mouseClicked = false;
    private bool playing = GameManagerScript.isPlaying;
    private Vector3 pos = new Vector3(0f, 0f, 0f);
    public static Vector3 spawnPoint = new Vector3(0f, 0f, 0f);

    void Update()
    {
        playing = GameManagerScript.isPlaying;
        if (playing)
        {
            if (Input.GetKey("w"))
            {
                pos.z += speed * Time.deltaTime;
            }
            if (Input.GetKey("s"))
            {
                pos.z -= speed * Time.deltaTime;
            }
            if (Input.GetKey("d"))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("a"))
            {
                pos.x -= speed * Time.deltaTime;
            }

            player.AddForce(pos, ForceMode.VelocityChange);
            pos = new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (!playing)
            player.position = spawnPoint;
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
                player.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                player.position = new Vector3(player.position.x, 1.0f, player.position.z);
                spawnPoint = player.position;
            }
        }
    }

    void OnMouseUp()
    {
        mouseClicked = false;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (playing)
        {
            if (collision.gameObject.name == "Objective")
            {
                GameManagerScript.changeGamemodeGlobal();
            }
        }
    }
}
