using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class HighScores : MonoBehaviour
{
    public static int[] highscores;

    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;
    public TextMeshProUGUI five;


    public static void AddToHS(int value)
    {
        if (highscores == null)
        {
            Debug.Log("highscores is null");
            highscores = new int[10];
           
        }
        Debug.Log("continue");
        if (value > highscores[highscores.Length-1]&&!highscores.Contains(value))
        {
            highscores[highscores.Length - 1] = value;
        }
        Array.Sort(highscores);
        Array.Reverse(highscores);
        Debug.Log(String.Join(" ", new List<int>(highscores).ConvertAll(i => i.ToString()).ToArray()));


    }

    public void DeleteHss()
    {
        Debug.Log("here");
        highscores= new int[10];
        SaveSystem.saveplayer(this);
        SaveSystem.loadplayer();
     
    }


    void Start()
    {
        SaveSystem.saveplayer(this);
       

        Playerdata data = SaveSystem.loadplayer();
        highscores = data.highscores;
        //Debug.Log(Application.persistentDataPath);
    }
    void OnApplicationQuit()
    {
        SaveSystem.saveplayer(this);
    }

    void Update()
    {
        Debug.Log(String.Join(" ", new List<int>(highscores).ConvertAll(i => i.ToString()).ToArray()));

        if (highscores[0].ToString() != "0")
        {
            one.text = highscores[0].ToString();
        }
        else
        {
            {
                one.text = "";
            }
        }
        if (highscores[1].ToString() != "0")
        {
            two.text = highscores[1].ToString();
        }
        else
        {
            {
                two.text = "";
            }
        }
        if (highscores[2].ToString() != "0")
        {
            three.text = highscores[2].ToString();
        }
        else
        {
            {
                three.text = "";
            }
        }
        if (highscores[3].ToString() != "0")
        {
            four.text = highscores[3].ToString();
        }
        else
        {
            {
                four.text = "";
            }
        }
        if (highscores[4].ToString() != "0")
        {
            five.text = highscores[4].ToString();
        }
        else
        {
            {
                five.text = "";
            }
        }



    }
}
