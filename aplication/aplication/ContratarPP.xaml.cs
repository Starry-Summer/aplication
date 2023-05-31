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
    public partial class ContratarPP : ContentPage
    {
        public ContratarPP()
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