using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(BinarySaving))]
public class BinarySavingEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        EditorGUILayout.HelpBox("Can work with a TMP_inputfield and GUI Buttons or without them.", MessageType.Info);
        BinarySaving binarySaving = (BinarySaving)target;
        if(GUILayout.Button("Save"))
        {
            binarySaving.Save();
        }
        if(GUILayout.Button("Load"))
        {
            binarySaving.Load();
        }
    }
}
