using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Interface.Example3
{
    public class PostSqlService : IDataService
    {
        public void Create()
        {
            //Post Sql Server Kaydet
        }

        public void Delete(int id)
        {
            //Post Sql Server Sil
        }

        public void Update(int id)
        {
            //Post Sql Server Güncelle
        }
    }
}
