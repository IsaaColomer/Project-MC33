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

    public void Update()
    {
        if(Input.GetKeyDown("p"))
        {
            Load();
        }
    }

    public void Save()
    {
        string dataPath = "C:/Users/Baobab/Desktop/Xml";
        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(stream, activeSave);
        stream.Close();

        Debug.Log("Saved!");
    }

    public void Load()
    {
        Debug.Log("Has Load from file SaveManagerDone: " + hasLoaded);
        string dataPath = "C:/Users/Baobab/Desktop/Xml";
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
        string dataPath = "C:/Users/Baobab/Desktop/Xml";
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            File.Delete(dataPath + "/" + activeSave.saveName + ".save");
        }
    }
}

[System.Serializable]
public class SaveData
{
    public string saveName;

    public Vector3 respawnPosition;

    public int deaths;

    public int puntuation;

    public bool firstCheckDone = false;
}
