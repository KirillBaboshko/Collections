﻿using System;
using System.Collections;
using static System.Console;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList1 = new ArrayList();
            WriteLine($"Вместимость по умолчанию: {arrayList1.Capacity}");
            arrayList1.Add("one");
            WriteLine($"Вместимость после добавления одного элемента: {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] { 2, 5, 48, 14 });
            WriteLine($"Вместимость после добавления коллекции: {arrayList1.Capacity}");
            arrayList1.Capacity = 10;
            WriteLine($"Вместимость после добавления коллекции: {arrayList1.Capacity}");
            WriteLine($"Фактическое количество элементов: {arrayList1.Count}");
            arrayList1.TrimToSize();
            WriteLine($"Вместимость уменьшена до рефльного количества элемента: {arrayList1.Capacity}");
            WriteLine($"Элемент с индексом 2: { arrayList1[2]}");
            WriteLine("Все элементы коллекции:");
            foreach (object item in arrayList1)
            {
                WriteLine($"\t{item}");
            }
        }
    }
}
