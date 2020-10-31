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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, string apellido, string user, string total, string dato1, string dato2, string dato3, string dato4)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblApellido.Text = apellido;
            lblTotal.Text = total;
            lblUser.Text = user;
            lblDato1.Text = dato1;
            lblDato2.Text = dato2;
            lblDato3.Text = dato3;
            lblDato4.Text = dato4;
        }
    }
}