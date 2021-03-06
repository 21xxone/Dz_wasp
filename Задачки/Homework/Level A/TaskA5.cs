using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    // Задача А5.
    // Кол-во стингеров: ⅓🔹
    //
    // Написать функцию ArrayOfTiers(int number), которая принимает число и возвращает список чисел, 
    // последовательно отсеченных по одному разряду.
    //
    // Пример:
    // ArrayOfTiers(420) ==> [4, 42, 420]
    // ArrayOfTiers(2021) ==> [2, 20, 202, 2021]
    public static class TaskA5
    {
        public static List<int> ArrayOfTiers(int number)
        {
            // Здесь необходимо написать код.
            List<int> result = new List<int>();
            string number_string = number.ToString();
            string result_string = "";
            for (int i = 0; i < number_string.Length; i++)
            {
                result_string = result_string + number_string[i];
                result.Add(Convert.ToInt32(result_string));
            }
            return result;
        }
    }
}
