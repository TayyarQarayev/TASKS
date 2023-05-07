using C__List_And_Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__List_And_Generic.Operations
{
    public class GenericOperation<T> : IGenericOperation<T>
    {
        protected ICollection<T> _collection;
        public GenericOperation(List<T> collection) 
        {
            _collection = collection;
        }
        public void Add(T entity)
        {
            _collection.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _collection;
        }
        public void Delete(T entity)
        {
            _collection.Remove(entity);
        }

    }
}
