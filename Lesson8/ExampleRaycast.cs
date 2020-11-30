namespace Geekbrains
{
    public sealed class ExampleRaycast
    {
        public void Main()
        {
            Example(out var x, out var y);
            Example(out _, out var y2);
            Example(out var x2, out _);
            Example(out _, out _);
        }

        private void Example(out int x, out int y)
        {
            x = 10;
            y = 10;
        }

        private void NameMethod()
        {
            int t;
            ExampleOne(out t);
            int t1 = 7;
            ExampleTwo(ref t1);
            int t2 = 9;
            Example(in t1);
        }

        private void ExampleOne(out int value)
        {
            value = 5;
        }

        private void ExampleTwo(ref int value)
        {
        }

        private void Example(in int value)
        {
        }

        private void ExampleR(in MyClass value)
        {
        }

        internal class MyClass
        {
            
        }
    }
}
