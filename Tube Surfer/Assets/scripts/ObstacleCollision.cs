﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     void OnCollisionEnter(Collision collision)
    {
       Debug.Log("boom");
        if (collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(0);

        }
    }
}
