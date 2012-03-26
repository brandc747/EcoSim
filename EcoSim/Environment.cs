using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    public class Environment
    {

        private int temp;
        /// <summary>
        /// Get/Set for environment temperature.
        /// </summary>

        public int Temperature
        {
            get
            {
                return temp;
            }
            set
            {
                temp = value;
            }
        }
    }
}
