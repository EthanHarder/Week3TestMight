using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool viewDir;

    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (!SingletonPlayState._instance.isPaused)
        {
            if (viewDir)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
            else
                this.transform.position -= Vector3.right * speed * Time.deltaTime;
        }
           
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            UnityEngine.Debug.Log("Hit");
            other.GetComponent<Enemy>().Hit();

            Destroy(this.gameObject);
        }
    }

}
