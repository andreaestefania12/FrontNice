using Proyecto.Models;
using Proyecto.Servicios;
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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void BtnCallWS_Click(object sender, EventArgs e)
        {
            servicioLogin client = new servicioLogin();
            var result = await client.Get<Usuario>("https://jsonplaceholder.typicode.com/posts/1");
            string h = string.Empty;

            if (result != null)
            {
                lblId.Text = $"{result.id}";
                lblTitle.Text = result.title;
                lblBody.Text = result.body;
            }

        }
    }

}