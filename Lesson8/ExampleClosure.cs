using System;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleClosure
    {
        public void Main()
        {
            var actions = new List<Action>();
            for (var i = 0; i < 100; i++)
            {
                var i1 = i;
                actions.Add(() => Debug.Log(i1));
            }

            foreach (var action in actions)
            {
                action();
            }
        }
    }
}

