using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTH.DAL
{
    public  interface IConectDB<T>
    {

        T GetById(int id);
        T GetByElement(T element);
        List<T> GetAll();
    }
}
