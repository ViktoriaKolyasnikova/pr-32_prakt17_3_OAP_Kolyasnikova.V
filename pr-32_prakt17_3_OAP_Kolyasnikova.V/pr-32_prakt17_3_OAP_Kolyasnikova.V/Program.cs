using System;
using System.Collections.Generic;
using System.Linq;
using System.IO; 
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt17_3_OAP_Kolyasnikova.V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt");
            StreamWriter sw = new StreamWriter("t2.txt");

            List<S> students = new List<S>();
            string str;
            while ((str = sr.ReadLine()) != null)
            {
                string[] t = str.Split(' ');
                students.Add(new S { F = t[0], I = t[1], O = t[2], G = t[3], B = Convert.ToDouble(t[4]) });
            }

            double max = students.Max(point => point.B);
            Console.WriteLine("Максимальный балл: " + max);
            sw.WriteLine("Максимальный балл: " + max);

            double min = students.Min(point => point.B);
            Console.WriteLine("Минимальный балл: " + min);
            sw.WriteLine("Минимальный балл: " + min);

            while(true)
                {
                Console.WriteLine("\nПроизвести сортировку студентов по баллам: 1-Возрастание 2-Убывание 3-Выход");
                string v = Console.ReadLine();
                switch (v)
                {
                    case "1":
                        var sortedStudents1 = from s in students
                                              orderby s.B ascending
                                              select s;
                        Console.WriteLine("\nСортировка студентов по возрастанию):");
                        sw.WriteLine("Сортировка студентов по возрастанию:");
                        foreach (S s in sortedStudents1)
                        {
                            Console.WriteLine($"{s.F} - {s.I} - {s.O} - {s.G} - {s.B}");
                            sw.WriteLine($"{s.F} - {s.I} - {s.O} - {s.G} - {s.B}");
                        }
                        break;
                    case "2":
                        var sortedStudents = from s in students
                                             orderby s.B descending
                                             select s;
                        Console.WriteLine("\nСортировка студентов по убыванию:");
                        sw.WriteLine("Сортировка студентов по убыванию:");
                        foreach (S s in sortedStudents)
                        {
                            Console.WriteLine($"{s.F} {s.I} {s.O} {s.G} {s.B}");
                            sw.WriteLine($"{s.F} {s.I} {s.O} {s.B} {s.B}");
                        }
                        break;
                    case "3":
                        return;
                }
            }
            sw.Close();
            Console.ReadLine();

        }
    }
   
} 

        
