using UnityEngine;
using System.Collections.Generic;
using System;

namespace Assets.MyScripts.Test
{
    public sealed class UnicCollection
    {       
        public void TestUnicCollection()
        {
            var list = new List<int>
            {
                1,
                2,
                4,
                7,
                4
            };
       
            foreach(var element in GetUniques(list))
            {
                Debug.Log(element.ToString());
            }
        }

        private ICollection<T> GetUniques<T>(ICollection<T> list)
        {
            // Для отслеживания элементов используйте словарь 
            Dictionary<T, bool> found = new Dictionary<T, bool>();
            List<T> uniques = new List<T>();
            // Этот алгоритм сохраняет оригинальный порядок элементов 
            foreach (T val in list)
            {
                if (!found.ContainsKey(val))
                {
                    found[val] = true;
                    uniques.Add(val);
                }
            }
            return uniques;
        }

        private void Reverse<T>(T[] array) // переворачивает коллекцию
        {
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                T temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }

    }
}
