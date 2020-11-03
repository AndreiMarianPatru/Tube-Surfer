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
    public int[] highscores;

    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    public TextMeshProUGUI three;
    public TextMeshProUGUI four;
    public TextMeshProUGUI five;


    public void AddToHS(int value)
    {
        value = Random.Range(0, 100);
        if (value > highscores[highscores.Length-1]&&!highscores.Contains(value))
        {
            highscores[highscores.Length - 1] = value;
        }
        Array.Sort(highscores);
        Array.Reverse(highscores);
     
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
        highscores= new int[10];
        for (int i = 0; i < highscores.Length; i++)
            highscores[i] = i;

        Playerdata data = SaveSystem.loadplayer();
        highscores = data.highscores;

      

        Debug.Log(Application.persistentDataPath);
    }
    void OnApplicationQuit()
    {
        SaveSystem.saveplayer(this);
    }

    void Update()
    { 
        Debug.Log("Human = " + String.Join(" ",
            new List<int>(highscores).ConvertAll(i => i.ToString()).ToArray()));

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
