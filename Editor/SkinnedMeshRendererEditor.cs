using UnityEngine;
using UnityEditor;
using UnityEditorInternal;
using System.Collections.Generic;

[CustomEditor(typeof(SkinnedMeshRenderer))]
public class SkinnedMeshRendererEditor : Editor
{
    private ReorderableList bonesList;
    private static List<Transform> copiedBones;

    private void OnEnable()
    {
        bonesList = new ReorderableList(
            serializedObject,
            serializedObject.FindProperty("m_Bones"),
            true, true, true, true);

        bonesList.drawHeaderCallback = (Rect rect) =>
        {
            EditorGUI.LabelField(rect, "Bones");
        };

        bonesList.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
        {
            SerializedProperty element = bonesList.serializedProperty.GetArrayElementAtIndex(index);
            rect.y += 2;
            EditorGUI.PropertyField(new Rect(rect.x, rect.y, rect.width, EditorGUIUtility.singleLineHeight),
                element, GUIContent.none);
        };
    }

    public override void OnInspectorGUI()
    {
        // Draw the default inspector
        DrawDefaultInspector();

        serializedObject.Update();

        // Draw the reorderable list
        bonesList.DoLayoutList();

        serializedObject.ApplyModifiedProperties();

        // Copy & Paste buttons
        EditorGUILayout.BeginHorizontal();

        if (GUILayout.Button("Copy Bones"))
        {
            SkinnedMeshRenderer skinnedMesh = (SkinnedMeshRenderer)target;
            copiedBones = new List<Transform>(skinnedMesh.bones);
        }

        if (GUILayout.Button("Paste Bones") && copiedBones != null)
        {
            SkinnedMeshRenderer skinnedMesh = (SkinnedMeshRenderer)target;
            skinnedMesh.bones = copiedBones.ToArray();
        }

        EditorGUILayout.EndHorizontal();
    }
}
