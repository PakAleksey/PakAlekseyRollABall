using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.MyScripts.Lesson5
{
    //task 2
    public static class Task2
    {
        public static int CountChar(this string str)
        {
            return str.Length;
        }
    }

    public sealed class PakAlekseyLesson5HW
    {                      
        //task 3
        private List<int> listInt = new List<int>() { 1, 3, 4, 3, 3, 4 };

        // подсчет одинаковых элементов в List<int>
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

        // подсчет одинаковых элементов в List<T>
        private void CountUnicElementsGeneric<T>(List<T> list) where T : IComparable
        {
            var unicList = new List<T>();
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (!unicList.Contains(list[i]))
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[i].CompareTo(list[j]) == 0)
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

        // подсчет одинаковых элементов в List<T> с помощью Linq
        private void CountUnicElementsGenericLinq<T>(List<T> list) where T : IComparable
        {
            var unicList = list.Distinct().ToList();
            for (int i = 0; i < unicList.Count; i++)
            {
                var monoList = list.Where(el => el.CompareTo(unicList[i]) == 0).ToList();
                Debug.Log($"{unicList[i]} - {monoList.Count}");
            }
        }


        private void Task4Lesson5()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four", 4},
                {"two", 2},
                {"three", 3},
                {"one", 1},
            };
            var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
            var d2 = dict.OrderBy(pair => pair.Value);
            var d3 = dict.OrderBy(ValueSort);
            foreach (var pair in d)
            {
                Debug.Log($"{pair.Key} - {pair.Value}");
            }

        }

        private int ValueSort(KeyValuePair<string, int> pair)
        {
            return pair.Value;
        }
    }
}
