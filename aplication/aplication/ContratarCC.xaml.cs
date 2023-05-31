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
    public partial class ContratarCC : ContentPage
    {
        public ContratarCC()
        {
            InitializeComponent();
        }

        private async void AgendaCita_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CitasPage());
        }

        private async void Volver_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }
    }
}