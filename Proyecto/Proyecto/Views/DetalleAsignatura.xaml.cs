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
    public partial class DetalleAsignatura : ContentPage
    {
        public DetalleAsignatura(String nombre, String nota, String inasistencia)
        {
            InitializeComponent();
            
            MyItemNameShow.Text = nombre;
            MyIngrediantItemShow.Text = nota;
            MyImageCall.Text = inasistencia;
        }
    }
}