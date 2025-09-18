using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{



    public float speed;

    public bool lookRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject Projectile;

    // Update is called once per frame
    void Update()
    {
        if (!SingletonPlayState._instance.isPaused)
        {
            Vector3 moveVec = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            if (moveVec.x > 0)
            {
                lookRight = true;
            }
            else
            {
                lookRight = false;
            }

                this.transform.position += moveVec * speed * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.F))
            {
                Projectile _newP = Instantiate(Projectile, this.transform.position, Quaternion.identity).GetComponent<Projectile>();
                _newP.viewDir = lookRight;
            }
        }   
 
        {
           
        }

        //if (excited && Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
        //    GetComponent<Rigidbody>().AddForce(new Vector3(0, 2.0f, 0) * jumpForce, ForceMode.Impulse);
        //    excited = false;
        }
    }


    
}
