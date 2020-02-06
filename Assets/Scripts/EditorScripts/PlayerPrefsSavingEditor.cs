using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(PlayerPrefsSaving))]
public class PlayerPrefsSavingEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        EditorGUILayout.HelpBox("Can work with a TMP_inputfield and GUI Buttons or without them.", MessageType.Info);
        PlayerPrefsSaving playerPrefsSaving = (PlayerPrefsSaving)target;
        if(GUILayout.Button("Save"))
        {
            playerPrefsSaving.Save();
        }
        if(GUILayout.Button("Load"))
        {
            playerPrefsSaving.Load();
        }
    }
}
