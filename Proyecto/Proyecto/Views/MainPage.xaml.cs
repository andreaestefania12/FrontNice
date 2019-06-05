using Proyecto.Models;
using Proyecto.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginCommand(object sender, EventArgs e)
        {
            var usuario = boxUsuario.Text;
            var contra = boxContraseña.Text;
            if((!string.IsNullOrEmpty(usuario)) && (!string.IsNullOrEmpty(contra)))
            {
                var user = new ModeloEstudiante { UserName = usuario};
                this.Navigation.PushModalAsync(new MenuHamburguesa());
            }
        }
    }
}
