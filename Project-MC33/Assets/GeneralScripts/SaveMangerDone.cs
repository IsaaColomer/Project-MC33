using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class SaveMangerDone : MonoBehaviour
{
    public static SaveMangerDone instance;
    public SaveData activeSave;

    public bool hasLoaded;

    public bool newGame;

    public void Awake()
    {       
        instance = this;
        Load();
    }

    public void Save()
    {
        string dataPath = Application.persistentDataPath;

        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(stream, activeSave);
        stream.Close();

        Debug.Log("Saved!");
    }

    public void Load()
    {
        Debug.Log("Has Load from file SaveManagerDone: " + hasLoaded);
        string dataPath = Application.persistentDataPath;
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            Debug.Log("Cockins");
            var serializer = new XmlSerializer(typeof(SaveData));
            var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Open);
            activeSave = serializer.Deserialize(stream) as SaveData;
            stream.Close();
            
            hasLoaded = true;
            Debug.Log("Loaded!");
        }
    }

    public void DeleteSavedData()
    {
        string dataPath = Application.persistentDataPath;
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            File.Delete(dataPath + "/" + activeSave.saveName + ".save");
        }
    }
    public void NewGameSavedData()
    {
        // Debug.Log("Reaches the start of NewGameSavedData");
        // GameObject pos = GameObject.Find("PlayerGeneral");
        // FallRestart posd = pos.GetComponent<FallRestart>();
        // Debug.Log("Reaches the Creation of the variable");
        // posd.rb.transform.position = new Vector3(-24f,1.6f,0f);
        // Debug.Log("New Position");

        string dataPath = Application.persistentDataPath;

        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(stream, activeSave);
        stream.Close();

        Debug.Log("Saved!2");
    }
}

[System.Serializable]
public class SaveData
{
    public string saveName;

    public Vector3 respawnPosition = new Vector3(-25f,-2f,0f);

    public int deaths;

    public int puntuation;
}
