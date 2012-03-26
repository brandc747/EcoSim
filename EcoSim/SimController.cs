using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSim
{
    class SimController : ISimController {

      ISimModel model;
      ISimView view;


      public SimController(ISimModel model, ISimView view)
      {
          this.model = model;
          this.view = view;
          this.view.AddListener(this);
      }


    }
}
