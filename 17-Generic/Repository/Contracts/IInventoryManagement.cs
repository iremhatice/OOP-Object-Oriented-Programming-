using _17_Generic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Generic.Repository.Contracts
{
    public interface IInventoryManagement<T> where T : Product
    {
        void Add(T item);
        void Remove(T item);
        void Update(T item, int id);
        T Get(int id);
        List<T> GetAll();
    }
}
