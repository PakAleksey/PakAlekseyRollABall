using System.Collections.Generic;

namespace Geekbrains
{
    public sealed class ExampleCovariance
    {
        public void Main()
        {
            Animals animals = new Cat();

            ITestCovariance<Animals> testInvariance = new TestCovariance<Animals>(); // Инвариантность: позволяет использовать только заданный тип

            ITestCovariance<Animals> testCovariance = new TestCovariance<Cat>(); // Ковариантность: позволяет использовать более конкретный тип, чем заданный изначально <out T>
            
            ITestContravariance<Cat> testContravariance = new TestContravariance<Animals>(); // Контравариантность: позволяет использовать более универсальный тип, чем заданный изначально <in T> 
            
            IEnumerable<Animals> animalses = new List<Cat>();
        }
    }

    public class Animals
    {
        public void Animal()
        {
            
        }
    }

    public class Cat : Animals
    {
        public void Cats()
        {
            
        }
    }

    public interface ITestCovariance<out T>
    {
        T Test(int t);
    }

    public class TestCovariance<T> : ITestCovariance<T>
    {
        public T Test(int t)
        {
            return default;
        }
    }   
    
    public interface ITestContravariance<in T>
    {
        void Test(T t);
    }

    public class TestContravariance<T> : ITestContravariance<T>
    {
        public void Test(T t)
        {
            
        }
    }
}
