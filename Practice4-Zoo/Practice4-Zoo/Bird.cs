using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_Zoo
{
    class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            AnimalType = "Bird";
        }      

        protected override string Communicate()
        {
            return "Tweeting";
        }

        protected override string Moving()
        {
            return "Flying";
        }

        protected override string Eating()
        {
            return "Eating Birdseed";
        }

        protected override string Sleeping()
        {
            return "Sleeping in a nest";
        }
    }
}
