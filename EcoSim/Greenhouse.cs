using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    public class Greenhouse
    {
        private List<Plant> plants;


        public Greenhouse()
        {
            plants = new List<Plant>();
        }


        /// <summary>
        /// This method gets the plants in the enviornment.
        /// </summary>
        public List<Plant> getPlants()
        {
            return plants;
        }

        /// <summary>
        /// This functions creates new plant in the environment.
        /// </summary>
        public void createPlant(Plant p)
        {
            plants.Add(p);
        }

        public void removePlant(Plant p)
        {
            plants.Remove(p);
        }
    }
}
