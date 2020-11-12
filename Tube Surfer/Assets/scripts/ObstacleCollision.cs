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
       Debug.Log("boooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooom");
        if (collision.gameObject.name== "player")
        {
            HighScores.AddToHS(Mathf.RoundToInt(Scoring.score));
          //  SceneManager.LoadScene(0);

        }
    }
}
