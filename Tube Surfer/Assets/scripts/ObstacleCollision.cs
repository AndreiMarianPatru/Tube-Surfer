using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // HighScores.highscores= new int[10];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name== "player")
        {
          
            HighScores.AddToHS(Mathf.RoundToInt(Scoring.score));
            //Time.timeScale = 0;
            Debug.Log(collision.gameObject.name+" hit"+gameObject.name+" at "+collision.contacts+"11111111111111111111111111111111111111111111111");
          //  SceneManager.LoadScene(0);

        }
    }

  
}
