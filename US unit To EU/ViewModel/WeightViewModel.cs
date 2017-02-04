using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace US_unit_To_EU.ViewModel
{
    class WeightViewModel : INotifyPropertyChanged
    {
        //prop
        public Model.Weight Weightprop { get; set; }

        //ctor
        public WeightViewModel()
        {
            Weightprop = new Model.Weight();
        }




        //Ounce til gram beregner
        public double OunceBeregner
        {

          get  { return Weightprop.Ounce * 28.349; }
        }


        #region så vi kan hente og vise dem
        
        private double henterOunce;

        public double HenterOunce
        {
            get { return henterOunce; }
            set
            {
                henterOunce = value;
                OnPropertyChanged(nameof(OunceBeregner));
            }
        }

        #endregion


        #region vores PropertyChangedEventHandler 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
