using System;

namespace AnimalFarm
{
    public class Chicken
    {
        private string name;
        private int age;
        private const int minAge = 0;
        private const int maxAge = 15;


        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => name;
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
            get => age;
            set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentException("Age must be between 0 and 15.");
                }
                age = value;
            }
        }

        public int ProductPerDay => CalculateProductPerDay(age);

        internal int CalculateProductPerDay(int age)
        {
            return age >= 0 && age < 5 ? 2 : 1;
        }
    }
}
