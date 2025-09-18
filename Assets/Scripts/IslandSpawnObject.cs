using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandSpawnObject : MonoBehaviour
{
    // Start is called before the first frame update


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Enact();
        }
    }

    public virtual void Enact()
    {
        UnityEngine.Debug.Log("Test");
    }
}
