using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IslandSpawnObject
{
    

    public override void Enact()
    {
        SingletonPlayState._instance.Restart();
    }


    public void Hit()
    {
        Destroy(this.gameObject);
    }
}
