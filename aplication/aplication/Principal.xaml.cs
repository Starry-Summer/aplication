using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Principal : ContentPage
    {
        public Principal()
        {
            InitializeComponent();
        }

        private async void ContratarCC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratarCC());
        }

        private async void ContratarPP_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContratarPP());
        }

    }
}