using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть 1");
            Console.WriteLine("Лабораторная работа №1");
            Console.WriteLine("Выполнил: Ёкубов Мухаммадилло");
            Console.WriteLine("Группа: ИНС-б-о-20-1; Специальность: 09.03.02");
            Console.WriteLine("Дата рождения: 2002.06.15");
            Console.WriteLine("Место жительства: г. Ставрополь, пр. Кулакова 2/1");
            Console.WriteLine("Любимый предмет в школе: Информатика");
            Console.WriteLine("Увлечения, хобби, интересы: Видеомонтаж, Машины, язык жестов, Волейболл");
            Console.ReadKey();
            part_2();
        }
        static void part_2()
        {
            Console.WriteLine("");
            Console.WriteLine("Часть 2 (Вариант №14)");
            int a = 5;
            int z = 15;
            float Et = 156.5f;
            float Zze = ((35 / a) * z) + (z * a) - ((a + Et) / 4);
            Console.WriteLine("a={0}; z={1}; Et={2}", a, z, Et);
            Console.WriteLine("Zze = ((35 / a) * z) + (z * a) - ((a + Et) / 4)");
            Console.WriteLine("Результат: Zze={0}", Zze);
            Console.ReadKey();
        }
    }
}
