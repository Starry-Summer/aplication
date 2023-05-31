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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void ingresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }

        private async void recuperar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecuperContrasena());
        }

        private async void registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrarsePage());
        }
    }
}