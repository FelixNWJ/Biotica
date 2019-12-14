using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    
    public static void SaveScore(GameManager game) {

        BinaryFormatter formatter = new BinaryFormatter();

        string pathToSave = Application.persistentDataPath + "collectibleHighScore.data";

        FileStream stream = new FileStream(pathToSave, FileMode.Create);

        GameData data = new GameData(game); 
        
        formatter.Serialize(stream, data);

        stream.Close();

    }

    public static GameData loadScore() {

        string pathToLoad = Application.persistentDataPath + "collectibleHighScore.data";

        try {

            FileStream stream = new FileStream(pathToLoad, FileMode.Open);

            BinaryFormatter formatter = new BinaryFormatter();

            GameData dataLoaded = formatter.Deserialize(stream) as GameData;

            stream.Close();

            return dataLoaded;


        } catch (FileNotFoundException e) {

            Debug.LogError(e.Message);

            return null;

        }

    }

}
