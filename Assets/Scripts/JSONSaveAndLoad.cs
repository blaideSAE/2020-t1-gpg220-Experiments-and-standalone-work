using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class JSONSaveAndLoad : MonoBehaviour
{
    /// <summary>
    /// just a clean basic JSON saving and loading example.
    /// </summary>
    public string jsonString;
    public string thingOne;
    public string subPath = "/SaveLoadExample.json";
    public string path;
    public bool loadOnStart;
    public TMP_InputField tmpInputField;
    
    public string fileSize;
    public TextMeshProUGUI fileSizeTextMeshProUgui;
    void Start()
    {
        path = Application.dataPath + subPath;
        
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
    
    public void Load()
    {
        jsonString = File.ReadAllText(path);
        SaveData saveData = JsonUtility.FromJson<SaveData>(jsonString);
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

    public void Save()
    {
        if (tmpInputField != null)
        {
            thingOne = tmpInputField.text;
        }
        SaveData saveData = new SaveData() ;
        saveData.thingOne = thingOne;
        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(path,json);
        fileSize = FileSize();
        if (fileSizeTextMeshProUgui != null)
        { 
            fileSizeTextMeshProUgui.text = fileSize;
        }
    }
}

[System.Serializable]
public class SaveData
{
    public string thingOne;
}

