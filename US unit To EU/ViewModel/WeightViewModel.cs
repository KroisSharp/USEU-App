using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_unit_To_EU.ViewModel
{
    class WeightViewModel
    {
        //prop
        public Model.Weight Weightprop { get; set; }


        //ctor
        public WeightViewModel()
        {
            Weightprop = new Model.Weight();
        }
    }
}
