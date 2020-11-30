using UnityEngine;

namespace Geekbrains
{
    public sealed class ExampleRefLocal
    {
        public void Main()
        {
            int readonlyArgument = 44;
            InArgExample(readonlyArgument);
            Debug.Log(readonlyArgument); // value is still 44

            void InArgExample(in int number)
            {
                // Uncomment the following line to see error CS8331
                //number = 19;
            }
        }
    }
}
