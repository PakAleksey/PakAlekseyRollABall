using UnityEditor;
using UnityEngine;

namespace Assets.MyScripts
{
    public sealed class MyWindowLesson7HW : EditorWindow
    {
        public GameObject Prefab;
        public int CountPrefabs;
        public string Name;
        private bool IsPressed;

        public void OnGUI()
        {
            GUILayout.Label("Моё первое кастомное окно", EditorStyles.boldLabel);
            EditorGUILayout.HelpBox("WARNING", MessageType.Warning);
            IsPressed = GUILayout.Toggle(IsPressed, "Поставьте галочку");           
            if (IsPressed)
            {
                EditorGUILayout.HelpBox("Вы поставили галочку", MessageType.Info);
                Prefab = EditorGUILayout.ObjectField("Выберите префаб", Prefab, typeof(GameObject), true) as GameObject;
                EditorGUILayout.LabelField("Количество префабов");
                CountPrefabs = EditorGUILayout.IntSlider(CountPrefabs, 1, 10);
                var IsCreate = GUILayout.Button("Создать префабы");
                CreatePrefabs(Prefab, IsCreate, CountPrefabs);
            }
        }

        public void CreatePrefabs(GameObject prefab, bool isCreate, int countPrefabs)
        {
            if (isCreate)
            {
                for (int i = 0; i < countPrefabs; i++)
                {
                    Instantiate(prefab, new Vector3(0, 0, i + 5), Quaternion.identity); 
                }
            }           
        }
    }
}
