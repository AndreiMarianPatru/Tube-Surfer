using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour
{

    public Text highscoretext;
    public Canvas endscreen;
    // Start is called before the first frame update
    void Start()
    {
        endscreen.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        int score = (int)Scoring.score;
        highscoretext.text = score.ToString();
        endscreen.enabled = true;
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
    public void playagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
