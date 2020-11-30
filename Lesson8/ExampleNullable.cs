using System;

namespace Geekbrains
{
    internal sealed class ExampleNullable
    {
        public void Main()
        {
            Test(null);

            if (NameMethod(null).HasValue)
            {
                
            }
            
            
        }
        
        private void Test(int? value)
        {
            Nullable<int> test;
        }

        private int? NameMethod(MyClass myClass)
        {
            if (myClass != null)
            {
                myClass.NameMethod();
            }

            myClass?.NameMethod();

            return 5;
        }

        internal class MyClass
        {
            public void NameMethod()
            {
                
            }
        }
    }
}
