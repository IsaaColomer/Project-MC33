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
            Save();
        }  

        if(Input.GetKeyDown(KeyCode.L))
        {
            GameObject pos03 = GameObject.Find("PlayerGeneral");
            FallRestart pos04 = pos03.GetComponent<FallRestart>();
            pos04.rb.transform.position = SaveMangerDone.instance.activeSave.respawnPosition;
            Load();            
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            DeleteSavedData();
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
    }
}

[System.Serializable]
public class SaveData
{
    public string saveName;

    public Vector3 respawnPosition;
}
