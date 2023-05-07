using C__List_And_Generic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__List_And_Generic.Operations
{
    public class ActorOperation : GenericOperation<Actor>,IActor
    {
        public ActorOperation(List<Actor> collection) : base(collection)
        {

        }
        public void GetFullName()
        {
            foreach (var actor in _collection)
            {
                Console.WriteLine($"Actor Full Name : {actor.FirstName} {actor.LastName}");
            }
        }
    }
}
