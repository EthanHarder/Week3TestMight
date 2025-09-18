using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorSpawner : MonoBehaviour
{

    [SerializeField]
    protected GameObject test;

    public abstract void Spawn();
}
