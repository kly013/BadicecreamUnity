using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FaceDirection
{
    Left, Right, Up, Down
}

public class Player : MonoBehaviour
{
    // 玩家初始位置
    public int GridX = 7;
    public int GridY = 13;

    public FaceDirection FaceDir = FaceDirection.Down;

    public void Update()
    {
        // 轉換格子座標
        Vector3 targetPos = CoordinateSystem.GridToPosition(GridX, GridY);

        // 漸漸移動
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);

        // 轉向
        if (FaceDir == FaceDirection.Left) 
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (FaceDir == FaceDirection.Right)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (FaceDir == FaceDirection.Up)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (FaceDir == FaceDirection.Down)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}
