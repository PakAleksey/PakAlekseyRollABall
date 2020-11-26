using UnityEngine;

namespace Assets.MyScripts
{
    public class Lesson7HWTestForEditor : MonoBehaviour
    {
        public MyPrefab Prefab;

        public void FindObject()
        {
            Prefab = GameObject.FindObjectOfType<MyPrefab>();
        }

        public void DeleteObject()
        {
            if (Prefab != null)
            {
                Prefab = null;
            }           
        }
    }
}

