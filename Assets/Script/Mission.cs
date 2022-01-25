using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public int[,] ItemMap;
    //public Image Picture;

    LevelController1 levelController1;

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger~~~~~");
        if (other.tag == "Player")
        {
            Debug.Log("Player~~");

            // 通知levelController1
            levelController1.OnMissionItemDestory();

            // 球消失
            Destroy(this.gameObject);
        }
    }
}
