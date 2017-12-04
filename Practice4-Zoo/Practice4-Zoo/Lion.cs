using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_Zoo
{
    class Lion : Animal
    {
        public Lion(string name) : base(name)
        {
            AnimalType = "Lion";                
        }        

        protected override string Communicate()
        {
            return "Roaring";
        }
      
        protected override string Moving()
        {
            return "Walking around the cage";
        }

        protected override string Eating()
        {
            return "Eating Meat";
        }

        protected override string Sleeping()
        {
            return "Sleeping on a rock";
        }

    }
}
