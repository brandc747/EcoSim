using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    public class Animal
    {
        private string enviornmentPreference;
        private int foodAmount;
        private int age;
        private int hunger;
        private Enum MutationType;


        public Animal()
        {
            foodAmount = 30;
        }

        
        /// <summary>
        /// This method determines whether the animal is hungry, if its hunger level is < 50
        /// </summary>
        public bool isHungry()
        {
            return (this.hunger < 50);
        }

        /// <summary>
        /// This method allows an animal to breed with another animal, to form offspring.
        /// Needs much more indepth checking, we don't want penguins breeding with horses, etc..
        /// </summary>
        public Animal breed(Animal a)
        {
            // TODO: implement breeding checker
            Animal offpsring = new Animal();
            return offpsring;
        }
    }
}
