using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica.N._9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataPage : ContentPage
    {
        public ObservableCollection<_13090351> Items { get; set; }
        
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<_13090351> Tabla;
      
        
        

        public DataPage()
        {
            InitializeComponent();
            
            cliente = new MobileServiceClient(AzureConnection.AzureURL);
            
           Tabla = cliente.GetTable<_13090351>();
            
            LeerTabla();
            Tabla.IncludeDeleted();
            
        }
        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new SelectPage(e.SelectedItem as _13090351));
        }

        private void Button_Insertar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }        private async void LeerTabla()
        {
            IEnumerable<_13090351> elementos = await Tabla.ToEnumerableAsync();
            Items = new ObservableCollection<_13090351>(elementos);
            BindingContext = this;
        }

        private  async void Button_Eliminados(object sender, EventArgs e)
        {
            IEnumerable<_13090351> elementos = await Tabla.IncludeDeleted().ToEnumerableAsync();
            Items = new ObservableCollection<_13090351>(elementos);
            BindingContext = this;
        }
    }
}