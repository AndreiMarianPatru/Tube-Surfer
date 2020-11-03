using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class HighScores : MonoBehaviour
{
    public int[] highscores;


    public void AddToHS(int value)
    {
       
        if (value < highscores[highscores.Length-1]&&!highscores.Contains(value))
        {
            highscores[highscores.Length - 1] = value;
        }
        Array.Sort(highscores);
    }


    void Start()
    {
        highscores= new int[10];
        for (int i = 0; i < highscores.Length; i++)
            highscores[i] = 100-i;
       
        //Playerdata data = SaveSystem.loadplayer();
        //highscores = data.highscores;
    }
    void OnApplicationQuit()
    {
        SaveSystem.saveplayer(this);
    }

    void Update()
    { 
        Debug.Log("Human = " + String.Join(" ",
            new List<int>(highscores).ConvertAll(i => i.ToString()).ToArray()));
    }
}
