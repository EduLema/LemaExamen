using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LemaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen()
        {
        }

        public Resumen(double pagototal, Label lblUsuario)
        {
            InitializeComponent();

           // lblUsuario.Text = usuario;
          //  lblPassword.Text = password;
            //lbltot.Text
        }
    }
}