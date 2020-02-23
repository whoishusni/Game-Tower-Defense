﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    // Start is called before the first frame update
    private float loadSceneTime = 2f;
    private float timer = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;

        if(timer>=loadSceneTime)
        {
            SceneManager.LoadScene("Gameplay");
        }
        
    }
}
