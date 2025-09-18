using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : ActorSpawner
{

    public void Start()
    {
        Spawn();
    }


    public override  void Spawn()
    {
        Instantiate(test, this.transform.position, Quaternion.identity);
    }
}
