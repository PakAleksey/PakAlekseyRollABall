using System;
using UnityEngine;


namespace Assets.MyScripts
{
    public sealed class Timer : MonoBehaviour
    {
        public float TimeStart;
        public bool IsStart;
        public event Action StopTimer = delegate {};

        private void Update()
        {            
            TimerGo();
        }

        public void TimerGo()
        {
            if (IsStart && TimeStart < 10)
            {
                TimeStart += Time.deltaTime;
            }
            else
            {
                StopTimer.Invoke();
            }
        }
    }
}
