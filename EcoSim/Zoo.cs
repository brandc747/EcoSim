using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    public class Zoo
    {

        private List<Animal> animals;


        public Zoo()
        {
            animals = new List<Animal>();
        }

        /// <summary>
        /// This method gets the animals in the environment
        /// </summary>
        public List<Animal> getAnimals()
        {
            return animals;
        }

        /// <summary>
        /// This method creates an animal passing through the given parameters.
        /// </summary>
        public void addAnimal(Animal a)
        {
            animals.Add(a);
        }


        /// <summary>
        /// This method removes the animal specified as a parameter from the ArrayList.
        /// </summary>
        public void removeAnimal(Animal a)
        {
            animals.Remove(a);
        }
    }
}
