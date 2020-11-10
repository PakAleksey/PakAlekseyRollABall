using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MyScripts.Test
{
    class ExamplePredicate
    {
        public void Main()
        {
            TraditionalDelegateSyntax();
            AnonymousMethodSyntax();
            LambdaExpressionSyntax();
        }

        // Цель для делегата Predicate<>.
        private bool IsEvenNumber(int i)
        {
            // Это четное число?
            return i % 2 == 0;
        }

        private void TraditionalDelegateSyntax()
        {
            // Создать список целых чисел
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 4, 4 });
            // Вызов FindAll() с использованием традиционного синтаксиса делегатов
            // Создаем обобщенный экземпляр обобщенного делегата, используя встроенный делегат Predicate
            Predicate<int> predicate = new Predicate<int>(IsEvenNumber);
            // Создаем список целых чисел, используя метод FindAll, в который передаем делегат
            List<int> evenNumbers = list.FindAll(predicate);
            Debug.Log("Здесь только четные числа:");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }
        }

        private void AnonymousMethodSyntax()
        {
            // Создать список целых чисел
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Теперь использовать анонимный метод
            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; });
            // Вывод четных чисел
            Debug.Log("Здесь только четные числа:");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }
        }

        private void LambdaExpressionSyntax()
        {
            // Создать список целых чисел
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
            // Теперь использовать лямбда-выражение C#
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            // Вывод четных чисел
            Debug.Log("Здесь только четные числа:");
            foreach (int evenNumber in evenNumbers)
            {
                Debug.Log(evenNumber);
            }
        }        

    }
}
