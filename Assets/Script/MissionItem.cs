using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionItem : MonoBehaviour
{
    public LevelController LvController;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // 通知levelController1
            LvController.OnMissionItemDestory(this);

            // 球消失
            Destroy(this.gameObject);
        }
    }
}
