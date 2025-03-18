using _17_Generic.Enum_s;
using _17_Generic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Models
{
    public abstract class Product
    {
        public static int id = 0;
        private int stock;
        private decimal price;

        public Product(string name, int stock)
        {
            Name = name;
            Id = ++id;
            Stock = stock;
        }
        public int Id { get; set; }
        public string Name { get; }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new StockAmountException("Fiyat sıfırdan küçük olamaz.");
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value > 0)
                    stock = value;
                else
                    throw new StockAmountException();

            }
        }
        public Status Status { get; set; } = Status.Active;
        public override string ToString()
        {
            return $"Product Id: {Id} Name: {Name}, Price: {Price:C} Stock: {Stock}";
        }
        public abstract decimal TaxPrice();

        public void AddStock(int stock)
        {
            if (stock <= 0)
                throw new StockAmountException();

            Stock += stock;
        }

        public void RemoveStock(int stock)
        {
            if (stock <= 0 || Stock < stock)
                throw new StockAmountException();

            Stock -= stock;
        }
    }
}
