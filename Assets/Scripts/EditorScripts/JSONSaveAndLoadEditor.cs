using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(JSONSaveAndLoad))]
public class JSONSaveAndLoadEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        EditorGUILayout.HelpBox("Can work with a TMP_inputfield and GUI Buttons or without them.", MessageType.Info);
        JSONSaveAndLoad jsonSaveAndLoad = (JSONSaveAndLoad)target;
        if(GUILayout.Button("Save"))
        {
            jsonSaveAndLoad.Save();
        }
        if(GUILayout.Button("Load"))
        {
            jsonSaveAndLoad.Load();
        }
    }
}
