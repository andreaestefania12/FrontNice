using Proyecto.Models;
using Proyecto.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Asignaturas : ContentPage
    {
        public Asignaturas()
        {
            InitializeComponent();
            BindingContext = new ListaAsignaturasViewModel();
        }

        private async void OnItemSelect(Object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as ModeloAsignatura;
            await Navigation.PushAsync(new DetalleAsignatura(mydetails.nombre, mydetails.nota, mydetails.inasistencia));
         
        }
    }
}