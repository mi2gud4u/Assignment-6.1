using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment_6._1
{
    enum HouseType
    {
        Ranch, 
        Craftsman, 
        Victorian, 
        Colonial,
        Modern
    }
    internal class House
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public HouseType HouseType { get; set; }

        public House next;
        public House(int houseNumber, string streetName, string cityName, HouseType houseType) 
        {
            HouseNumber = houseNumber;
            StreetName = streetName;
            CityName = cityName;
            HouseType = houseType;
            next = null;
        }
    }

    class LinkdList
    {
        private House head;
        private House tail;
        private int size;

        

        public LinkdList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Add(int houseNumber, string streetName, string cityName, HouseType houseType)
        {
            House newHouse = new House(houseNumber, streetName, cityName, houseType);
            if (IsEmpty())
            {
                this.head = newHouse;
                this.tail = newHouse;
            }
            else
            {
                newHouse.next = head;
                head = newHouse;
            }
            size++;
        }

        public void Display()
        {
            House temp = head;
            if (IsEmpty())
            {
                Console.WriteLine("House list is Empty.");
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp != null)
                    {
                        Console.WriteLine($"{temp.HouseNumber} {temp.StreetName}, {temp.CityName} | House Type: {temp.HouseType}"); 
                    }
                    temp = temp.next;
                }
            }
        }

        public void Search(string streetName, int? number = null)
        {
            House temp = head;

            if (IsEmpty())
            {
                Console.WriteLine("House list is Empty.");
                return;
            }

            Console.WriteLine("\nHouse information:");
            while (temp != null)
            {
                if (number == null && temp.StreetName == streetName)
                {
                    Console.WriteLine($"{temp.HouseNumber} {temp.StreetName}");
                    Console.WriteLine(temp.CityName);
                    Console.WriteLine($"House Type: {temp.HouseType}");
                    return;
                }
                if (number != null && temp.HouseNumber == number && temp.StreetName == streetName)
                {
                    Console.WriteLine($"{temp.HouseNumber} {temp.StreetName}");
                    Console.WriteLine(temp.CityName);
                    Console.WriteLine($"House Type: {temp.HouseType}");
                    return;
                }

                temp = temp.next;
            }
            Console.WriteLine("No records found!");


        }

    }

}
