using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void saveplayer(HighScores scores)
    {
        BinaryFormatter formatter= new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.hs";
        FileStream stream = new FileStream(path,FileMode.Create);

        Playerdata data= new Playerdata(scores);
        formatter.Serialize(stream,data);
        stream.Close();
    }

    public static Playerdata loadplayer()
    {
        string path = Application.persistentDataPath + "/player.hs";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream =new FileStream(path,FileMode.Open);
            Playerdata data = formatter.Deserialize(stream) as Playerdata;
            stream.Close();
            return data;


        }
        else
        {
            Debug.LogError("Savefile not found");
            return null;
        }
    }

}
