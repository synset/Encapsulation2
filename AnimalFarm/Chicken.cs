using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
    class Chicken
    {
        private string name;
        private int age;
        private int productPerDay;
        private const int minAge = 0;
        private const int maxAge = 15;


        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null, empty or whitespace.");
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < minAge || value > maxAge)
                {
                    throw new ArgumentException("Age must be between 0 and 15.");
                }
                this.age = value;
            }
        }

        public int ProductPerDay
        {
            get 
            {
                return this.CalculateProductPerDay(age);
            }
        }

        private int CalculateProductPerDay(int age)
        {
            if (age >= 0 && age < 5)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }
    }













}
