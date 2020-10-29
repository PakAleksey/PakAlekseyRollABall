using UnityEngine;


namespace Assets.MyScripts.Test
{
    class TestStarterMonoBeh : MonoBehaviour
    {
        private DelegateTest _delegateTest;
        private SwichChangeTo_Dictionary _swichChange;
        private EventTest _eventTest;

        private void Start()
        {
            var addComponent = CubeTestEvent.CreateTestCube(100);
            addComponent.ShowHP += AddComponent_ShowHP;           

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
