using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static bool isPlaying = false;

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
}
