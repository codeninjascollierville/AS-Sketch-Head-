using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Platform gameobject 
    [Header("Platform Object")]
    public GameObject platform;
    //Default position for platform
    float pos = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Interger i equalls 1000
        for (int i = 0; i < 1000; i++)
        {
            //Exucute SpawnPlatforms 
            SpawnPlatforms();

        }



        // Update is called once per frame
        void Update()
        {

        }
    }

