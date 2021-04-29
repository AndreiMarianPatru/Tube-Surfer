using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialTrigger : MonoBehaviour
{
    
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
      
        endscreen.enabled = true;
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Main Menu");

    }
    public void playagain()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Resources.UnloadUnusedAssets();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag=="Player")
        {
            EndGame();

        }
    }
}
