using UnityEditor;
using UnityEngine;


namespace Assets.MyScripts
{
    [CustomEditor(typeof(Lesson7HWTestForEditor))]
    public sealed class Lesson7HWEditor : Editor
    {
        private bool IsPressedFind;
        private bool IsPressedDelete;

        public override void OnInspectorGUI()
        {
            var myTarget = (Lesson7HWTestForEditor)target;
            myTarget.Prefab =
                EditorGUILayout.ObjectField("Искомый объект", myTarget.Prefab, typeof(MyPrefab), false) as MyPrefab;
            var IsFind = GUILayout.Button("Найти Объект");
            var IsDelete = GUILayout.Button("Удалить объект");
            if (IsPressedFind || IsFind)
            {
                myTarget.FindObject();
                GUILayout.Label("Age", EditorStyles.boldLabel);
                myTarget.Prefab.Age = EditorGUILayout.IntSlider(myTarget.Prefab.Age, 1, 100);
                GUILayout.Label("Name", EditorStyles.boldLabel);
                myTarget.Prefab.Name = EditorGUILayout.TextField(myTarget.Prefab.Name);
                IsPressedFind = true;
            }
            if (IsPressedDelete || IsDelete)
            {
                myTarget.DeleteObject();
                IsPressedFind = false;
            }
        }
    }
}
