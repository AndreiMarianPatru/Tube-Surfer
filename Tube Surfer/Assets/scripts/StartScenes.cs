using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public void StartTutorial()
    {
        SceneManager.LoadScene(1);
    }

    public void StartMainGame()
    {
        SceneManager.LoadScene(2);
    }

    public void StartHighscores()
    {
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
