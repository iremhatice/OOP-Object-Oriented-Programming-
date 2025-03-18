using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example3
{
    public interface IDataService
    {
        void Create();
        void Update(int id);
        void Delete(int id);
    }
}
