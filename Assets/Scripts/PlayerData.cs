using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public PlayerData(Player player)
    {
        position = new float[3];
        //index 0 = x coordinate, index 1 = y coordinate, index 2 = z coordinate
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

    private int score;
    public float[] position;
}
