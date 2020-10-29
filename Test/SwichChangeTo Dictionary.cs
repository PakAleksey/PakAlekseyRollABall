using System;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.MyScripts.Test
{
    class SwichChangeTo_Dictionary : DelegateTest
    {
        private Dictionary<string, Action> _actions;

        public void EnumMethod(string value)
        {

            _actions = new Dictionary<string, Action>
            {
                ["Move"] = Move,
                ["Attak"] = Attak,
            };

            _actions[value].Invoke(); // делегат выполняется в одном потоке, что и вся программа
            var beginInvoke = _actions[value].BeginInvoke(CallBack, null); // делегат выполняется в другом потоке, после завершения вызовется CallBack
            var beginInvoke2 = _actions[value].BeginInvoke(null, null); // ничего после делегата не вызовется

            if (beginInvoke.IsCompleted)
            {
                Debug.Log($"Завершился CallBack метод");
            }

            //switch (value)
            //{
            //    case "Action":
            //        Move();
            //        break;
            //    case "Func":
            //        Attak();
            //        break;
            //}
        }

        private void CallBack(IAsyncResult result)
        {
            Debug.Log($"Метод, который вызывается после основного");
        }

        public void Move()
        {
            Debug.Log($"Move");
        }

        public void Attak()
        {
            Debug.Log($"Attak");
        }
    }
}
