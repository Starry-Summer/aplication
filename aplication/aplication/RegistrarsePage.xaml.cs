using aplication.Models;
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
    public partial class RegistrarsePage : ContentPage
    {
        public RegistrarsePage()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            if (validar())
            {
                Conection conec = new Conection
                {
                    IdUser=int.Parse(txtId.Text),
                    NameUser=txtNombre.Text,
                    EmailUser=txtEmail.Text,
                    PasswordUser=txtContraseña.Text
                };
                await App.SQLiteDB.SaveClienteAsync(conec);
                txtId.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                txtContraseña.Text = "";
                await DisplayAlert("Registro", "Guardado de forma exitosa", "Ok");
            }
            else
            {
                await DisplayAlert("Advertencia","Ingresar todos los datos", "Ok");
            }
        }

        public bool validar()
        {
            bool respuesta;

            if (string.IsNullOrEmpty(txtId.Text)) 
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}