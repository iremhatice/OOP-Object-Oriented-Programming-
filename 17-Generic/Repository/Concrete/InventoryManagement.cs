using _17_Generic.Models;
using _17_Generic.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Repository.Concrete
{
    public class InventoryManagement<T> : IInventoryManagement<T> where T : Product
    {
        public void Add(T item)
        {
            var hasProduct = false;
            foreach (var product in AppDbContext.products)
            {
                if (product.Id == item.Id)
                {
                    product.AddStock(item.Stock);
                    hasProduct = true;
                }
            }

            if (!hasProduct)
                AppDbContext.products.Add(item);
        }

        public T Get(int id)
        {
            foreach (var product in AppDbContext.products)
            {
                if (product.Id.Equals(id) && product is T)
                    return (T)product;
            }
            return null;
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();

            foreach (var item in AppDbContext.products)
            {
                if (item is T)
                    list.Add((T)item);
            }

            return list;
        }

        public void Remove(T item)
        {
            AppDbContext.products.Remove(item);
        }

        public void Update(T item, int id)
        {
            var productT = Get(id);
            if (productT is not null)
            {
                productT.Price = item.Price;
                productT.Stock = item.Stock == default ? productT.Stock : item.Stock;
            }
        }
    }
}
