﻿namespace StartUp
{
    public class Product
    {
        private string name;
        private decimal cost;
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");

                }
                cost = value;
            }
        }

        public string Name
        {
            get { return name; }
            set      
            {
                if (!string.IsNullOrEmpty(value.Trim()))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }

    }
}