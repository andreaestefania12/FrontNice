using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.Xaml;

namespace Proyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuHamburguesa : MasterDetailPage
    {
        public MenuHamburguesa()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            List<Menu> menu = new List<Menu>
            {
                new Menu { Page = new Asignaturas(), MenuTitle = "Asignaturas", Icon = "logo.png" },
                new Menu { Page = new Horario(), MenuTitle = "Horario", Icon = "horario.png" },
                new Menu { Page = new Biblioteca(), MenuTitle = "Biblioteca", Icon = "biblioteca.png" },
                new Menu { Page = new MainPage(), MenuTitle = "Cerrar Sesión", Icon = "exit.png" }
            };

            ListMenu.ItemsSource = menu;
            Detail = new Xamarin.Forms.NavigationPage(new Asignaturas())
            {
                BarBackgroundColor = Color.FromHex("#033E8C"),
                BarTextColor = Color.White
            };
        }

        void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false; //El menú hamburguesa se esconde 
                if(menu.MenuTitle == "Cerrar Sesión")
                {
                    this.Navigation.PushModalAsync(new MainPage());
                }
                else
                {
                    Detail = new Xamarin.Forms.NavigationPage(menu.Page)
                    {
                        BarBackgroundColor = Color.FromHex("#033E8C"),
                        BarTextColor = Color.White
                    };
                }
                
            }
        }

        public class Menu
        {
            public string MenuTitle
            {
                get; set;
            }

            public ImageSource Icon { get; set; }

            public Page Page { get; set; }
        }

        
    }
}