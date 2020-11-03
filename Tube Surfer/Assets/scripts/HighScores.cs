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
        one.text = highscores[0].ToString();
        two.text = highscores[1].ToString();
        three.text = highscores[2].ToString();
        four.text = highscores[3].ToString();
        five.text = highscores[4].ToString();
    }


    void Start()
    {
        highscores= new int[10];
        for (int i = 0; i < highscores.Length; i++)
            highscores[i] = i;

        Playerdata data = SaveSystem.loadplayer();
        highscores = data.highscores;

        one.text = highscores[0].ToString();
        two.text = highscores[1].ToString();
        three.text = highscores[2].ToString();
        four.text = highscores[3].ToString();
        five.text = highscores[4].ToString();
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
