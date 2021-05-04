using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEsc : MonoBehaviour
{
    public Canvas canvas;
    private bool paused;
    private bool ADswaped;
    private bool Wswaped;
    public Button swapADbutton;
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Rotate rotate;
    public Slider volumeslider;
    // Start is called before the first frame update

    private void Awake()
    {
        Time.timeScale = 1;

    }
    void Start()
    {
        canvas.enabled = false;
        paused = false;
        swapADbutton.image.sprite = OffSprite;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("esc");
            if (paused == true)
            {
                Debug.Log("unpaused");

                paused = false;
                canvas.enabled = false;
                Time.timeScale = 1;
                return;
            }
            if (paused == false)

            {
                Debug.Log("paused");

                paused = true;
                canvas.enabled = true;
                Time.timeScale = 0;

                return;

            }

        }
    }

    public void SwapAD()
    {
        ADswaped = !ADswaped;
        if (ADswaped == true)
        {
            swapADbutton.image.sprite = OnSprite;
            Rotate.swapped = true;
        }
        if (ADswaped == false)
        {
            swapADbutton.image.sprite = OffSprite;
            Rotate.swapped = false;


        }


    }
    public void UseW()
    {
        Wswaped = !Wswaped;
        if (Wswaped == true)
        {
            swapADbutton.image.sprite = OnSprite;
        }
        if (Wswaped == false)
        {
            swapADbutton.image.sprite = OffSprite;

        }


    }
    public void Quittomainmenu()
    {

        SceneManager.LoadScene("Main Menu");
    }


    public void changeVolume(System.Single newVolume)
    {
        PlayerPrefs.SetFloat("volume", newVolume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
}


