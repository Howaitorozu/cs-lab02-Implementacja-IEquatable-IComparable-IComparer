﻿using com.sun.org.apache.xpath.@internal.operations;
using System;

namespace Implementacja_dodatkowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //DateTime teraz = DateTime.Today;
            //DateTime zatrud = new DateTime(2020,09,22);
            //Console.WriteLine(teraz-zatrud);
            //Pracownik p1 = new Pracownik("Kowalski", DateTime.Today, 200);
            //Pracownik p2 = new Pracownik("Kowalski", DateTime.Today, 220);

            //Console.WriteLine(Equals(p1, p2));
            //var p3 = new Pracownik();
            //p3.Wynagrodzenie = 100;
            //p3.Nazwisko = "   Molenda  ";
            //p3.DataZatrudnienia = new DateTime(2010, 10, 01);
            //Console.WriteLine(p3);


            var p1 = new Pracownik();
            Console.WriteLine(p1);
            p1.Wynagrodzenie = 100;
            p1.Nazwisko = "   Molenda  ";
            p1.DataZatrudnienia = new DateTime(2010, 10, 01);
            Console.WriteLine(p1);

            var p2 = new Pracownik("Abacki", new DateTime(2011, 8, 9), 200);
            Console.WriteLine(p2);


            Krok1();
        }



        static void Krok1()
        {
            Console.WriteLine("--- Sprawdzenie poprawności tworzenia obiektu ---");
            Pracownik p = new Pracownik("Kowalski", new DateTime(2010, 10, 1), 1_000);
            Console.WriteLine(p);

            Console.WriteLine("--- Sprawdzenie równości obiektów ---");
            Pracownik p1 = new Pracownik("Nowak", new DateTime(2010, 10, 1), 1_000);
            Pracownik p2 = new Pracownik("Nowak", new DateTime(2010, 10, 1), 1_000);
            Pracownik p3 = new Pracownik("Kowalski", new DateTime(2010, 10, 1), 1_000);
            Pracownik p4 = p1;
            Console.WriteLine($"p1: {p1} hashCode: {p1.GetHashCode()}");
            Console.WriteLine($"p2: {p2} hashCode: {p2.GetHashCode()}");
            Console.WriteLine($"p3: {p3} hashCode: {p3.GetHashCode()}");
            Console.WriteLine($"p4: {p4} hashCode: {p4.GetHashCode()}");
            Console.WriteLine();

            Console.WriteLine($"--- Równość dla p1 oraz p2 -");
            Console.WriteLine($"Object.ReferenceEquals(p1, p2): {Object.ReferenceEquals(p1, p2)}");
            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
            Console.WriteLine($"p1 == p2: {p1 == p2}");
            Console.WriteLine();

            Console.WriteLine($"--- Równość dla p1 oraz p3 -");
            Console.WriteLine($"Object.ReferenceEquals(p1, p3): {Object.ReferenceEquals(p1, p3)}");
            Console.WriteLine(value: $"p1.Equals(p3): {p1.Equals(p3)}");
            Console.WriteLine($"p1 == p3: {p1 == p3}");
            Console.WriteLine();

            Console.WriteLine($"--- Równość dla p1 oraz p4 -");
            Console.WriteLine($"Object.ReferenceEquals(p1, p4): {Object.ReferenceEquals(p1, p4)}");
            Console.WriteLine($"p1.Equals(p3): {p1.Equals(p4)}");
            Console.WriteLine($"p1 == p4: {p1 == p4}");
        }



    }
}
