using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SimplePluginTest : MonoBehaviour
{
    public Transform cube;
    Vector3 pos = new Vector3(0f, 0f, 0f);
    const string DLL_NAME = "PLUGIN";

    [DllImport(DLL_NAME)]
    private static extern int SaveObject(float x, float y, float z);

    [DllImport(DLL_NAME)]
    private static extern void LoadFile();

    [DllImport(DLL_NAME)]
    private static extern float getX();

    [DllImport(DLL_NAME)]
    private static extern float getY();

    [DllImport(DLL_NAME)]
    private static extern float getZ();

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("l"))
        {
            LoadFile();

            pos.x = getX();
            pos.y = getY();
            pos.z = getZ();
            cube.position = pos;
        }
        if (Input.GetKey("p"))
        {

            if (SaveObject(cube.position.x, cube.position.y, cube.position.z) == 1)
            {
                Debug.Log("File Loaded");
            }
            else Debug.Log("Couldn't load file");
        }
    }
}
