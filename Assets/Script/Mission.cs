using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MapCreate
{
    public GameObject RB;
    public GameObject YB;

    void Update()
    {
        if (Level == 1)
        {
            YB.SetActive(false);
            RB.SetActive(true);
        }
        else if(Level == 2)
        {
            RB.SetActive(false);
            YB.SetActive(true);
        }
        else
        {
            RB.SetActive(false);
            YB.SetActive(false);
        }
    }
}
