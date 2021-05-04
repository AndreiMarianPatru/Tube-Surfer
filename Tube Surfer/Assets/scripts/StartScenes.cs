using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScenes : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
         Application.targetFrameRate = -1;
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Main Game");
        }

    }

    public void StartTutorial()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Resources.UnloadUnusedAssets();
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Single);
    }

    public void StartMainGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void StartHighscores()
    {
        SceneManager.LoadScene("Highscores");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
