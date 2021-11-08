﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А6.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию OddNumbers, которая получает на вход список целых чисел arr и целое число n и
    // возвращает список, состоящий из n последних вхождений нечетных чисел списка arr в том же порядке
    //
    // Пример:
    // ([1, 2, 3, 4, 5, 6, 7, 8, 9], 3) => [5, 7, 9]
    public static class TaskA6
    {
        public static List<int> OddNumbers(List<int> arr, int n)
        {
            // Здесь необходимо написать код.
            List<int> result = new List<int>();
            for (int i = arr.Count() - 1; i >= 0; i--)
            {
                if (arr[i] % 2 != 0)
                {
                    result.Insert(0, arr[i]);
                }
                if (result.Count == n)
                {
                    break;
                }
            }
            return result;
        }
    }
}
