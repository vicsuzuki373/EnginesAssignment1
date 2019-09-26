using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        Instantiate(wall, new Vector3(0, 5, 0), Quaternion.identity);
    }
}
