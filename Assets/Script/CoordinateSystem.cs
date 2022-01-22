using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoordinateSystem : MonoBehaviour
{
    public static float World_x = -75;
    public static float World_z = 75;
    public static float Ratio = 10;

    public static Vector3 GridToPosition(int gx, int gz)
    {
        float Grid_x;
        float Grid_z;

        // x偏移量 + x座標 * 放大比例
        Grid_x = World_x+ gx * Ratio; 
        // z偏移量 - z座標 * 放大比例
        Grid_z = World_z - gz * Ratio; 

        return new Vector3(Grid_x, 5, Grid_z);
    }
}
