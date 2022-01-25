using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController1 : LevelController
{
    // 玩家初始位置
    int cur_x = 7;
    int cur_y = 13;

    int BallNum = 20;

    void Start()
    {
        // 定義冰塊地圖
        IceMap = new int[16, 16]
        {
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,0,0,1,1,1,0,0,0,0,1,1,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1 },
            { 1,0,0,1,1,1,0,0,0,0,1,1,1,0,0,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
            { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
        };

        // 初始化任務列表
        Missions = new List<Mission>();

        // 定義任務1
        Mission mission1 = new Mission();
        mission1.ItemMap = new int[16, 16]
        {
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,2,2,0,0,0,0,0,0,0,0,2,2,0,0 },
            { 0,0,2,0,0,0,0,0,0,0,0,0,0,2,0,0 },
            { 0,0,0,0,0,0,2,0,0,2,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,2,0,0,0,0,2,0,0,0,0,0 },
            { 0,0,0,0,0,2,0,0,0,0,2,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,2,0,0,2,0,0,0,0,0,0 },
            { 0,0,2,0,0,0,0,0,0,0,0,0,0,2,0,0 },
            { 0,0,2,2,0,0,0,0,0,0,0,0,2,2,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        };
        Missions.Add(mission1);

        // 定義任務2
        Mission mission2 = new Mission();
        mission2.ItemMap = new int[16, 16]
        {
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,3,3,0,0,0,0,0,0,0,0,0,0,3,3,0 },
            { 0,3,0,0,0,0,0,0,0,0,0,0,0,0,3,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,3,0,0,0,0,0,0,3,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,3,0,0,0,0,0,0,3,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,3,0,0,0,0,0,0,0,0,0,0,0,0,3,0 },
            { 0,3,3,0,0,0,0,0,0,0,0,0,0,3,3,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        };
        Missions.Add(mission2);

        // 初始化任務地圖
        CreateMapItems(IceMap);
        InitMission(Missions[0]);
    }

 
    void Update()
    {
        // 角色控制
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (IceMap[cur_y, cur_x-1] != 1) 
            {
                player.transform.Translate(-10, 0, 0, Space.World);
                cur_x--;
                player.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (IceMap[cur_y, cur_x + 1] != 1)
            {
                player.transform.Translate(10, 0, 0, Space.World);
                cur_x++;
                player.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (IceMap[cur_y - 1, cur_x] != 1) 
            {
                player.transform.Translate(0, 0, 10, Space.World);
                cur_y--;
                player.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (IceMap[cur_y + 1, cur_x] != 1)
            {
                player.transform.Translate(0, 0, -10, Space.World);
                cur_y++;
                player.transform.rotation = Quaternion.Euler(0, 180, 0);
            }
        }
    }

    public void OnMissionItemDestory()
    {
        BallNum--;
        Debug.Log("BallNum = " + BallNum);
        if (BallNum == 0)
        {
            Debug.Log("Finish");
        }
    }
}
