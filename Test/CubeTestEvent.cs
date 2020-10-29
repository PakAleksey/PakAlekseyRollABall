using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


namespace Assets.MyScripts.Test
{
    public class CubeTestEvent : MonoBehaviour
    {
        private int _hp;
        public event Action<int> ShowHP = delegate(int i) { };

        public static CubeTestEvent CreateTestCube(int hp) // паттерн фабричный метод
        {
            var result = GameObject.CreatePrimitive(PrimitiveType.Cube).AddComponent<CubeTestEvent>();
            result._hp = hp;
            result.name = (nameof(CubeTestEvent));
            result.gameObject.GetComponent<BoxCollider>().isTrigger = true;
            result.gameObject.AddComponent<Rigidbody>().useGravity = false;

            return result;
        }

        private void OnTriggerEnter(Collider other)
        {
            ShowHP.Invoke(_hp--);
        }
    }
}
