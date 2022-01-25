using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int[,] IceMap;
    public int CurrMissionNum = 0;
    public List<int[,]> Missions;
    public List<MissionItem> missionItems;

    public GameObject ice;
    public MissionItem redball;
    public MissionItem yellowball;
    public Player player;

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
                    MissionItem item = Instantiate(redball, CoordinateSystem.GridToPosition(x, y), Quaternion.identity);
                    item.LvController = this;
                    missionItems.Add(item);
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
    public void InitMission(int[,] mission)
    {
        // 在地圖上產生目標物件
        CreateMapItems(mission);
    }

    public void OnMissionItemDestory(MissionItem item)
    {
        missionItems.Remove(item);
        Debug.Log("Item = " + missionItems.Count);
        if (missionItems.Count == 0)
        {
            Debug.Log("Finish");
        }
    }

    public void PlayerControl()
    {
        // 角色控制
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.FaceDir = FaceDirection.Left;
            if (IceMap[player.GridY, player.GridX - 1] != 1)
            {
                player.GridX--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.FaceDir = FaceDirection.Right;
            if (IceMap[player.GridY, player.GridX + 1] != 1)
            {
                player.GridX++;
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.FaceDir = FaceDirection.Up;
            if (IceMap[player.GridY - 1, player.GridX] != 1)
            {
                player.GridY--;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.FaceDir = FaceDirection.Down;
            if (IceMap[player.GridY + 1, player.GridX] != 1)
            {
                player.GridY++;
            }
        }
    }
}
