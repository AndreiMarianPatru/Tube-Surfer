using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Playerdata
{
    public int[] highscores;

  
    public Playerdata(HighScores highscore)
    {
        highscores = highscore.highscores;
    }

    
}
