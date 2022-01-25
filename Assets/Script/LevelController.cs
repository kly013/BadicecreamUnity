using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int[,] IceMap;
    public int MissionNum = 0;
    public List<Mission> Missions;

    public GameObject ice;
    public GameObject redball;
    public GameObject yellowball;
    public GameObject player;

    // 由地圖陣列產生物件
    public void CreateMapItems(int[,] map)
    {
        for (int y = 0; y < 16; y++)
        {
            for (int x = 0; x < 16; x++)
            {
                // 產生冰塊
                if (map[y, x] == 1)
                {
                    Instantiate(ice, CoordinateSystem.GridToPosition(x, y), Quaternion.identity);
                }

                // 產生紅球
                if (map[y, x] == 2)
                {
                    Instantiate(redball, CoordinateSystem.GridToPosition(x, y), Quaternion.identity);
                }

                // 產生黃球
                if (map[y, x] == 3)
                {
                    Instantiate(yellowball, CoordinateSystem.GridToPosition(x, y), Quaternion.identity);
                }
            }
        }
    }

    // 初始化 Mission
    public void InitMission(Mission mission)
    {
        // 在地圖上產生目標物件
        CreateMapItems(mission.ItemMap);
    }
}
