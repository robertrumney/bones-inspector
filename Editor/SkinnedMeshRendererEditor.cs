using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SkinnedMeshRenderer))]
public class SkinnedMeshRendererEditor : Editor
{
    public override void OnInspectorGUI()
    {
        // Draw the default inspector
        DrawDefaultInspector();

        // Get reference to SkinnedMeshRenderer
        SkinnedMeshRenderer skinnedMesh = (SkinnedMeshRenderer)target;

        // Display bones
        EditorGUILayout.LabelField("Bones", EditorStyles.boldLabel);

        if (skinnedMesh.bones != null && skinnedMesh.bones.Length > 0)
        {
            for (int i = 0; i < skinnedMesh.bones.Length; i++)
            {
                skinnedMesh.bones[i] = (Transform)EditorGUILayout.ObjectField("Bone " + i, skinnedMesh.bones[i], typeof(Transform), true);
            }
        }
        else
        {
            EditorGUILayout.LabelField("No bones assigned.");
        }
    }
}
