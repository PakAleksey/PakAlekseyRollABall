using System;
using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleChecked
    {
        public void Main()
        {
            int a = 150;
            int b = 150;

            try
            {
                byte result = checked((byte)(a + b));
                Debug.Log(result);
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
    }
}
