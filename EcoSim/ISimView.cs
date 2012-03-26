using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    interface ISimView
    {
        void AddListener(ISimController controller);

    }
}
