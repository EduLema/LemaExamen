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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
        }

        public Registro( string usuario, string password)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblPassword.Text = password;
            //txtUsuario.Text = usuario;
            //txtPassword.Text = password;     
            

        }

        private void Label_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void txtMensual_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtmInicial_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                double pagoInicial = Convert.ToDouble(txtmInicial.Text);

                if ((pagoInicial >= 1) && (pagoInicial <= 1800))
                {

                    double calculo = ((1800 - pagoInicial) / 3 )+ 90;
                    txtMensual.Text = Convert.ToString(calculo);
                }
                else
                {
                                 
                }
                   

            }
            catch (Exception ex)
            {

                DisplayAlert("Mensaje de Advertencia", ex.Message, "OK");

            }
        }

        private void DisplayAlert(string v1, object message, string v2)
        {
            throw new NotImplementedException();
        }

        private async void txtGuardar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen());

            await Navigation.PushAsync(new Resumen());

            

        }
    }
}