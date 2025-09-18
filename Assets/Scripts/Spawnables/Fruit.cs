using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : IslandSpawnObject
{
    public override void Enact()
    {
        SingletonPlayState._instance.lives++;
        if (SingletonPlayState._instance.lives >= 7)
        {
            SingletonPlayState._instance.isPaused = true;
        }
        Destroy(this.gameObject);
    }

}
