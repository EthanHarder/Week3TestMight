using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SingletonPlayState : MonoBehaviour
{

    public static SingletonPlayState _instance;

    public  bool isPaused = false;

    public int lives = 5;


    // Start is called before the first frame update
    void Awake()
    {
       if ( _instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
       else
        {
            Destroy(this);
        }
    }


    public void Restart()
    {
        if (lives > 0)
        {
            lives--;
            SceneManager.LoadScene("SampleScene");

        }
        else isPaused = true;
    }



    
}
