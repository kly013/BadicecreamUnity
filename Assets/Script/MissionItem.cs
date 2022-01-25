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
            // �q��levelController1
            LvController.OnMissionItemDestory(this);

            // �y����
            Destroy(this.gameObject);
        }
    }
}
