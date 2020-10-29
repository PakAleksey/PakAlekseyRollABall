using System;
using UnityEngine;


namespace Assets.MyScripts.Test
{
    class EventTest
    {
        public event Action _testEvent;

        public void StartEventTest()
        {
            _testEvent?.Invoke();
        }
    }
}
