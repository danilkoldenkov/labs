using System;
using System.Collections.Generic;
using System.Text;

namespace Laba1_1
{
    struct team
    {
        public string fio;
        public string type;
        public int oc;
        public int exp;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            team[] m = new team[n];
            team[] m1 = new team[n];
            team[] m2 = new team[n];
            team[] m3 = new team[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите ФИО: ");
                m1[i].fio = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите Тип(Спортсмен - С, Тренер - Т: ");
                m[i].type = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите год рождения: ");
                m2[i].oc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите опыт: ");
                m3[i].exp = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Состав спортклуба\nФИО\t\tТип\tГод рождения\tОпыт (лет)");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(m1[i].fio + " \t " + m[i].type + " \t " + m2[i].oc +"\t\t"+m3[i].exp + "\t");
            }
            Console.WriteLine("Перечисляемый тип: Т - тренер, С - спортсмен");
        }
    }
}