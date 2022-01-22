using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoordinateSystem
{
    public static float World_x = -75;
    public static float World_z = 75;
    public static float Ratio = 10;

    public static Vector3 GridToPosition(int gx, int gz)
    {
        float px;
        float pz;

        // x偏移量 + x座標 * 放大比例
        px = World_x + gx * Ratio; 

        // z偏移量 - z座標 * 放大比例
        pz = World_z - gz * Ratio; 

        return new Vector3(px, 5, pz);
    }
}
