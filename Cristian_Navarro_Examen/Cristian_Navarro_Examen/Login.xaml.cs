using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cristian_Navarro_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            //Login  Text
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user != "estudiante2020" || pass != "uisrael2020")
            {
                await DisplayAlert("Alerta", "Usuario o Password incorrectos", "Reintentar");
                return;
            }
            else
            {
                await Navigation.PushAsync(new Registro(user, pass));
                await DisplayAlert("Acceso Correcto", "Bienvenido al registro de cursos online", "Aceptar");
            }
        }
    }
}