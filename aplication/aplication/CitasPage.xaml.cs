using aplication.cita;
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
    public partial class CitasPage : ContentPage
    {
        string place;
        public CitasPage()
        {
            InitializeComponent();
        }

        private async void Agendar_Clicked(object sender, EventArgs e)
        {
            if (Validar())
            {
                Conection conecti = new Conection
                {
                    IdUser = int.Parse(txtId.Text),
                    NameUser = txtNombre.Text,
                    PhoneUser = int.Parse(txtPhone.Text),
                    SitioUser = place,
                    DirectionUser = txtDirec.Text,
                    Entrenamiento = txtTrena.Text,
                    DuraEntrena = txtDuraTrena.Text,
                    InicioEntrena = txtHourBegin.Text,
                    DiaEntrena = int.Parse(txtDay.Text),
                    MesEntrena = int.Parse(txtMouth.Text),
                    AñoEntrena = int.Parse(txtYear.Text),
                };
                await App.SQLiteBD.SaveCitaAsync(conecti);
                txtId.Text = "";
                txtNombre.Text = "";
                txtPhone.Text = "";
                txtDirec.Text = "";
                txtTrena.Text = "";
                txtDuraTrena.Text = "";
                txtHourBegin.Text = "";
                txtDay.Text = "";
                txtMouth.Text = "";
                txtYear.Text = "";
                await DisplayAlert("Cita", "Agendada con exito", "Ok");
            }
            else
            {
                await DisplayAlert("Advertencia", "Ingresar todos los datos", "Ok");
            }
        }

        public bool Validar() 
        {
            bool respuesta;
            if (txt1.IsChecked == true)
            {
                place = "Casa";
            }
            else if (txt2.IsChecked == true)
            {
                place = "Gimnasio";
            }
            else
            {
                place = "";
            }

            if (string.IsNullOrEmpty(txtId.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtTrena.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtHourBegin.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtDuraTrena.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtDay.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtMouth.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtYear.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(place))
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