using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using TMPro;
using UnityEngine;
/// <summary>
/// This is just a test for binary saving, Trying to keep it clean and simple.
/// </summary>
public class BinarySaving : MonoBehaviour
{
    public string thingOne;
    public bool loadOnStart;
    public TMP_InputField tmpInputField;
    public string subPath = "/save.dat";
    public string path;
    
    public string fileSize;
    public TextMeshProUGUI fileSizeTextMeshProUgui;
    void Start()
    {
        path = Application.persistentDataPath + subPath;
        
        if (loadOnStart)
        {
            Load();
        }
    }
    public string FileSize()
    {
        var fileInfo = new System.IO.FileInfo(path);
        Debug.Log(fileInfo.Length);
        return  fileInfo.Length.ToString() + " B";
    }
    
    public void Save()
    {
        if (tmpInputField != null)
        {
            thingOne = tmpInputField.text;
        }
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open( path, FileMode.OpenOrCreate);
        SaveData saveData = new SaveData ();
        saveData.thingOne = thingOne;
        bf.Serialize(file, saveData);
        file.Close();
        fileSize = FileSize();
        if (fileSizeTextMeshProUgui != null)
        { 
            fileSizeTextMeshProUgui.text = fileSize;
        }
    }

    public void Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.OpenOrCreate);
        SaveData saveData = new SaveData ();
        saveData = (SaveData)bf.Deserialize(file);
        file.Close();
        thingOne = saveData.thingOne;
        
        if (tmpInputField != null)
        {
            tmpInputField.text = thingOne;
        }
        
        fileSize = FileSize();
        if (fileSizeTextMeshProUgui != null)
        { 
            fileSizeTextMeshProUgui.text = fileSize;
        }
    }
}