using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class GameManagerScript : MonoBehaviour
{
    const string DLL_NAME = "PLUGIN";

    [DllImport(DLL_NAME)]
    private static extern void SaveWall(float x, float y, float z, float qx, float qy, float qz, float qw);
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
    private static extern float getQuatX(int n);
    [DllImport(DLL_NAME)]
    private static extern float getQuatY(int n);
    [DllImport(DLL_NAME)]
    private static extern float getQuatZ(int n);
    [DllImport(DLL_NAME)]
    private static extern float getQuatW(int n);
    [DllImport(DLL_NAME)]
    private static extern int getSize();

    public GameObject player;
    public GameObject objective;
    public GameObject wall;
    public static List<GameObject> Walls = new List<GameObject>() { };
    public static bool isPlaying = false;

    public void Duplicate()
    {
        Walls.Add(Instantiate(wall, new Vector3(0, 5, 0), Quaternion.identity));
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
        for(int i =0;i<Walls.Count;i++)
        {
            if(Walls[i] != null)
                SaveWall(Walls[i].transform.position.x, Walls[i].transform.position.y, Walls[i].transform.position.z, Walls[i].transform.rotation.x, Walls[i].transform.rotation.y, Walls[i].transform.rotation.z, Walls[i].transform.rotation.w);
        }
        SaveToFile();
    }

    public void LoadScene()
    {
        LoadFile();
        Movement.spawnPoint = new Vector3(getPX(), getPY(), getPZ());
        player.transform.SetPositionAndRotation(new Vector3(getPX(), getPY(), getPZ()),Quaternion.identity);
        objective.transform.SetPositionAndRotation(new Vector3(getOX(), getOY(), getOZ()), Quaternion.identity);
        for(int i = 0;i<Walls.Count;i++)
        {
            if (Walls[i] != null)
                Destroy(Walls[i]);
        }
        Walls.Clear();
        for (int i = 0;i<getSize();i++)
        {
            Quaternion temp;
            temp.x = getQuatX(i);
            temp.y = getQuatY(i);
            temp.z = getQuatZ(i);
            temp.w = getQuatW(i);
            Walls.Add(Instantiate(wall, new Vector3(getX(i), getY(i), getZ(i)), temp));
        }
    }
}
