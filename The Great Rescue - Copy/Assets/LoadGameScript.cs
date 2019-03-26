﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {

            ScoreScript.ScoreValue = 0;
            BodyCount.Goblin = 0;
            BodyCount.Troll = 0;
            BodyCount.Orc = 0;


            PlayerScript.health = 5;
            HealthScore.HealthValue = 5;
            Application.LoadLevel(Application.loadedLevel);

            UnityEngine.SceneManagement.SceneManager.LoadScene("3. MainScene");


        }
    }
}
