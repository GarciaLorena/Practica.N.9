using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica.N._9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
      
        public InsertPage()
        {
            InitializeComponent();
           
        }

        private async void Button_Insertar_Clicked(object sender, EventArgs e)
        {
            var datos = new _13090351
            {
                Id = Entry_Matricula.Text,
                Dato1 = Entry_Nombre.Text,
                Dato2 = Entry_Apellido.Text,
                Dato3 = Entry_Direccion.Text,
                Dato4 = Entry_Telefono.Text,
                Dato5 = Entry_Carrera.Text,
                Dato6 = Entry_Semestre.Text,
                Dato7 = Entry_Correo.Text,
                Dato8 = Entry_GitHub.Text
            };
            await DataPage.Tabla.InsertAsync(datos);
           await Navigation.PushAsync(new DataPage());


        }
    }
}