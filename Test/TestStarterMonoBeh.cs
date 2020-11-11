using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Assets.MyScripts.Test
{
    class TestStarterMonoBeh : MonoBehaviour
    {
        private DelegateTest _delegateTest;
        private SwichChangeTo_Dictionary _swichChange;
        private EventTest _eventTest;
        private List<int> listInt = new List<int>() {1,3,4,3,3,4};

        private void CountUnicElements(List<int> list)
        {
            List<int> unicList = new List<int>();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {                
                if (!unicList.Contains(list[i]))
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i] == list[j])
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    continue;
                }
                if (!unicList.Contains(list[i]))
                {
                    unicList.Add(list[i]);
                }
                Debug.Log($"{list[i]} - {count}");
                count = 0;
            }
        }

        private void CountUnicElementsGeneric<T>(List<T> list) // только у Т должен быть перегружен оператор ==
        {
            var unicList = new List<T>();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (!unicList.Contains(list[i]))
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if ((object)list[i] == (object)list[j])
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    continue;
                }
                if (!unicList.Contains(list[i]))
                {
                    unicList.Add(list[i]);
                }
                Debug.Log($"{list[i]} - {count}");
                count = 0;
            }
        }


        private void Start()
        {
            CountUnicElementsGeneric(listInt);

            //CountUnicElements(listInt);

            //Debug.Log("jsfjs".CountChar());

            //gameObject.GetOrAddComponent<Rigidbody>();

            //Debug.Log("false".TryBool());

            //var list = new List<int>();
            //4.AddTo(list);


            //ExamplePredicate examplePredicate = new ExamplePredicate();
            //examplePredicate.Main();

            //UnicCollection unicCollection = new UnicCollection();
            //unicCollection.TestUnicCollection();

            //DelegatesObserver.Source s = new DelegatesObserver.Source();
            //DelegatesObserver.Observer1 o1 = new DelegatesObserver.Observer1();
            //DelegatesObserver.Observer2 o2 = new DelegatesObserver.Observer2();
            //DelegatesObserver.MyDelegate d1 = new DelegatesObserver.MyDelegate(o1.Do);
            //s.Add(d1);
            //s.Add(o2.Do);
            //s.Run();
            //s.Remove(o1.Do);
            //s.Run();

            //var list = new List<int>();
            //4.IsEven();
            //4.AddTo(list);

            //var example = FindObjectOfType<PredicateAndFuncDelegatesExample>();
            //example.Predicate = collision => collision.gameObject.CompareTag("Player");
            //const float damage = 50;
            //example.Func = f => f - damage;

            //var addComponent = CubeTestEvent.CreateTestCube(100);
            //addComponent.ShowHP += AddComponent_ShowHP;           

            //_eventTest = new EventTest();
            //_eventTest._testEvent += _eventTest__testEvent;
            //_eventTest.StartEventTest();

            //_swichChange = new SwichChangeTo_Dictionary();
            //_swichChange.EnumMethod("Move");

            //_delegateTest = new DelegateTest();
            //_delegateTest.Test();
            //_delegateTest.StartDelegate();            
            //_delegateTest.DeleteDelegate(() => Debug.Log("Babek"));
            //_delegateTest.StartDelegate();
        }

        private void AddComponent_ShowHP(int _hp)
        {
            Debug.Log($"HP = {_hp}");
        }

        private void _eventTest__testEvent()
        {
            Debug.Log($"Сработал подписанный метод");
        }


    }
}
