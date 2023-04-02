using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_and_IEnumerable
{
    internal class DogHome : IEnumerable<Dog>
    {
        // list of type Dog
        public List<Dog> dogList;

        // Make a constructor that will initialize some values
        public DogHome()
        {
            dogList = new List<Dog>()
            {
                new Dog("Rex", true),
                new Dog("Butch", true),
                new Dog("Fido", false),
                new Dog("Spheal", false),
                new Dog("Ellie", true)
            };
        }

        public IEnumerator<Dog> GetEnumerator()
        {
            return dogList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() //This is unused. It is for Non generic collections, but we are only using generic.
        {
            throw new NotImplementedException();
            //Even though it's unused NEEDS to be included as without presence the interface won't work.
        }
    }
}
