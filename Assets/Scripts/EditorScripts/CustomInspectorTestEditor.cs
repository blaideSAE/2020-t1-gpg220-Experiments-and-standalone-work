using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Just some custom Inspector stuff for testing..
/// </summary>
 [CustomEditor(typeof(CustomInspectorTest))]
public class CustomInspectorTestEditor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
        EditorGUILayout.HelpBox("just putting a button here to do stuff i guess.", MessageType.Info);
        CustomInspectorTest customInspectorTest = (CustomInspectorTest)target;
        if(GUILayout.Button("I'm a button."))
        {
            customInspectorTest.ButtonPress();
        }
    }

}
