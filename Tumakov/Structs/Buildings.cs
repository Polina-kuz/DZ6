using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov.Structs
{
    class Buildings
    {
        private static long numberr = 1000000;
        private long number;
        private double height;
        private int floors;
        private int apartments;
        private int entry;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public int Apartments
        {
            get { return apartments; }
            set { apartments = value; }
        }
        public int Entry
        {
            get { return entry; }
            set { entry = value; }
        }
        public Building(double height, int floors, int apartments, int entry)
        {
            number = GenerateNumber();
            Height = height;
            Floors = floors;
            Apartments = apartments;
            Entry = entry;
        }
        private long GenerateNumber()
        {
            return ++numberr;
        }
        public double FloorHeight()
        {
            return Height / Floors;
        }
        public int ApartmentsEntry()
        {
            return Apartments / Entry;
        }
        public int ApartmentsFloor()
        {
            return ApartmentsEntry() / Floors;
        }

        public void PrintBuilding()
        {
            Console.WriteLine($"Уникальный номер здания: {number}");
            Console.WriteLine($"Высота здания: {height} метров");
            Console.WriteLine($"Количество этажей: {floors}");
            Console.WriteLine($"Всего квартир: {apartments}");
            Console.WriteLine($"Количество подъездов: {entry}");
            Console.WriteLine($"Средняя высота этажа: {FloorHeight()} метров");
            Console.WriteLine($"Квартир в подъезде: {ApartmentsEntry()}");
            Console.WriteLine($"Квартир на этаже: {ApartmentsFloor()}");
        }
    }
}
