using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class GameManagerScript : MonoBehaviour
{
    const string DLL_NAME = "PLUGIN";

    [DllImport(DLL_NAME)]
    private static extern void SaveWall(float x, float y, float z, float degrees);
    [DllImport(DLL_NAME)]
    private static extern void SavePlayer(float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern void SaveObjective(float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern void SaveToFile();
    [DllImport(DLL_NAME)]
    private static extern void LoadFile();
    [DllImport(DLL_NAME)]
    private static extern float getPX();
    [DllImport(DLL_NAME)]
    private static extern float getPY();
    [DllImport(DLL_NAME)]
    private static extern float getPZ();
    [DllImport(DLL_NAME)]
    private static extern float getOX();
    [DllImport(DLL_NAME)]
    private static extern float getOY();
    [DllImport(DLL_NAME)]
    private static extern float getOZ();
    [DllImport(DLL_NAME)]
    private static extern float getX(int n);
    [DllImport(DLL_NAME)]
    private static extern float getY(int n);
    [DllImport(DLL_NAME)]
    private static extern float getZ(int n);
    [DllImport(DLL_NAME)]
    private static extern float getAngle(int n);

    public GameObject player;
    public GameObject objective;
    public GameObject wall;
    public static List<GameObject> Walls = new List<GameObject>() { };
    private int listSize = 0;
    public static bool isPlaying = false;

    public void Duplicate()
    {
        Walls.Add(Instantiate(wall, new Vector3(0, 5, 0), Quaternion.identity));
        listSize++;
    }

    public void changeGamemode()
    {
        if (isPlaying)
            isPlaying = false;
        else
            isPlaying = true;
    }

    public static void changeGamemodeGlobal()
    {
        if (isPlaying)
            isPlaying = false;
        else
            isPlaying = true;
    }

    public void SaveScene()
    {
        SavePlayer(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        SaveObjective(objective.transform.position.x, objective.transform.position.y, objective.transform.position.z);
        for(int i =0;i<listSize;i++)
        {
            SaveWall(Walls[i].transform.position.x, Walls[i].transform.position.y, Walls[i].transform.position.z, Walls[i].transform.rotation.y);
        }
        SaveToFile();
    }

    public void LoadScene()
    {
        LoadFile();
        Movement.spawnPoint = new Vector3(getPX(), getPY(), getPZ());
        player.transform.SetPositionAndRotation(new Vector3(getPX(), getPY(), getPZ()),Quaternion.identity);
        objective.transform.SetPositionAndRotation(new Vector3(getOX(), getOY(), getOZ()), Quaternion.identity);
    }
}
