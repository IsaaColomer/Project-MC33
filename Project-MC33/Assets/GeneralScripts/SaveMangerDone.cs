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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject asd = GameObject.Find("PlayerGeneral");
            FallRestart asdf = asd.GetComponent<FallRestart>();
            asdf.death = SaveMangerDone.instance.activeSave.deaths;

            GameObject yd = GameObject.Find("PlayerGeneral");
            OnTrigEnter ass = yd.GetComponent<OnTrigEnter>();
            ass.puntuation = SaveMangerDone.instance.activeSave.puntuation;

            Save();
        }   
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
        string dataPath = Application.persistentDataPath;
        if(System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
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
        GameObject pos = GameObject.Find("PlayerGeneral");
        FallRestart posd = pos.GetComponent<FallRestart>();
        posd.rb.transform.position = new Vector3(-25.8f,0f,0f);
        Debug.Log("New Position");
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
