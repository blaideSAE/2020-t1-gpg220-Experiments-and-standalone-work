using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPrefsSaving : MonoBehaviour
{
    /// <summary>
    /// Just a super basic clean player prefs saving and loading example
    /// </summary>
    public string thingOne;
    public bool loadOnStart;
    public TMP_InputField tmpInputField;
    public string fileSize;
    public TextMeshProUGUI fileSizeTextMeshProUgui;
    // Start is called before the first frame update
    void Start()
    {
        if (loadOnStart)
        {
         Load();
        }
    }

    public string FileSize()
    {
        /*var fileInfo = new System.IO.FileInfo("some/Path");
        Debug.Log(fileInfo.Length);
        return  fileInfo.Length.ToString() + " b";*/
        // Not great for player prefs, as its not easy to find the file location on different OS's
        return "error";
    }

    public void Save()
    {
        if (tmpInputField != null)
        {
            thingOne = tmpInputField.text;
        }
        PlayerPrefs.SetString("thing 1", thingOne);
        fileSize = FileSize();
        if (fileSizeTextMeshProUgui != null)
        { 
            fileSizeTextMeshProUgui.text = fileSize;
        }

    }
    
    public void Load()
    {
        thingOne = PlayerPrefs.GetString("thing 1");
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
