using System;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

namespace Assets.MyScripts.Test
{
    public delegate void MyDelegate();
    public class DelegateTest
    {
        private MyDelegate _myDelegate;
        private Action<int> _action;
        private Func<int, int> _func;
        private Predicate<int> _predicate;

        public DelegateTest()
        {
            _action = Action;
            _func = Func;
            _predicate = Predicate;
        }

        public void Action(int i)
        {
            Debug.Log("Action");
        }

        public int Func(int i)
        {
            Debug.Log("Func");
            return i;
        }

        public bool Predicate(int i)
        {
            Debug.Log("Predicate");
            return true;
        }

        public void Test()
        {
            _myDelegate += MyDelegateMethod;
            _myDelegate += () => Debug.Log("fafha");
            _myDelegate += delegate { Debug.Log("fa.kfjal"); };
        }

        public void MyDelegateMethod()
        {
            Debug.Log($"!afa");
        }

        public void StartDelegate()
        {
            Debug.Log("*********************************");          
            _myDelegate?.Invoke();
        }

        public void DeleteDelegate(MyDelegate myDelegate)
        {           
            _myDelegate -= MyDelegateMethod;
            _myDelegate += myDelegate;
        }       
    }
}
