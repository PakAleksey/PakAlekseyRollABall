using System;
using UnityEngine;

namespace Assets.MyScripts.Test
{
    public sealed class DelegatesObserver
    {
        public delegate void MyDelegate(object o);
        public sealed class Source
        {
            private MyDelegate _functions;

            public void Add(MyDelegate f)
            {
                _functions += f;
            }

            public void Remove(MyDelegate f)
            {
                _functions -= f;
            }

            public void Run()
            {
                Debug.Log("RUNS!");
                if (_functions != null) _functions(this);
            }
        }

        public sealed class Observer1 // Наблюдатель 1
        {
            public void Do(object o)
            {
                Debug.Log($"Первый. Принял, что объект {nameof(o)} побежал");
            }
        }

        public sealed class Observer2 // Наблюдатель 2
        {
            public void Do(object o)
            {
                Debug.Log($"Второй. Принял, что объект {nameof(o)} побежал");
            }
        }
    }
}
