using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleLazy
    {
        private string _title;

        public sealed class Singleton
        {
            private Singleton() { }
            
            private static readonly Lazy<Singleton> _instance = 
                new Lazy<Singleton>(() => new Singleton());

            public static Singleton Instance => _instance.Value;

            public void Test()
            {
                Debug.Log("Hello World");
            }
        }

        public void Main()
        {
            Singleton.Instance.Test();
        }

        public string Title
        {
            get
            {
                if (String.IsNullOrEmpty(_title))
                {
                    _title = "fgfd";
                }

                return _title;
            }
        }
    }
}
