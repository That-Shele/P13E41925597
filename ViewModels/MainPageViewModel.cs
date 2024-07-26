using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13E41925597.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string m2;
        [ObservableProperty]
        private string costo;
        [ObservableProperty]
        private string total;

        [RelayCommand]
        private void SacarTotal()
        {
            if (double.TryParse(M2, out double m2) && double.TryParse(Costo, out double costo))
            {
                Total = "El total a pagar es : $" + (m2 * costo);
            }
            else
            {
                Total = "Ingrese datos numericos";
            }
        }
    }
}
