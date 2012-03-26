using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    class SimModel : ISimModel
    {

        private Greenhouse greenhouse;
        private Zoo zoo;

        public SimModel()
        {
            greenhouse = new Greenhouse();
            zoo = new Zoo();
        }

    }
}
