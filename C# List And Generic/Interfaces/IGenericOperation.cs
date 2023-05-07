using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__List_And_Generic.Interfaces
{
    public interface IGenericOperation<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();
        void Delete(T entity);
    }
}
