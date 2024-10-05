using LINQList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

        Console.OutputEncoding = Encoding.UTF8;

        List<Student> students = new List<Student>
        {
            new Student("Вероніка", 18, 11),
            new Student("Андрій", 15, 11),
            new Student("Артем", 15, 10),
            new Student("Олег", 15, 10),
            new Student("Сергій", 19, 11),
            new Student("Тимур", 15, 10),
            new Student("Мирослав", 17, 10),
            new Student("Юрій", 16, 12),
            new Student("Іван", 16, 10),
            new Student("Андрій", 15, 10),
        };

        Console.WriteLine("Початковий список студентів:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nСортування за віком:");
        var sortedByAge = students.OrderBy(s => s.Age);
        foreach (var student in sortedByAge)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nСортування за середнім балом (спадання):");
        var sortedByGradeDesc = students.OrderByDescending(s => s.Grade);
        foreach (var student in sortedByGradeDesc)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nСортування за ім'ям:");
        var sortedByName = students.OrderBy(s => s.Name);
        foreach (var student in sortedByName)
        {
            Console.WriteLine(student);
        }
