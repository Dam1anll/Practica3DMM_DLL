using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica3DMM_DLL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void Criticar_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;

            string alto = null;
            string listo = null;
            string raro = null;
            string feo = null;
            string extravagante = null;
            string grande = null;

            if (Alto.IsChecked)
                alto = Hombre.IsChecked ? "Alto" : "Alta";

            if (Listo.IsChecked)
                listo = Hombre.IsChecked ? "Listo" : "Lista";

            if (Raro.IsChecked)
                raro = Hombre.IsChecked ? "Raro" : "Rara";

            if (Feo.IsChecked)
                feo = Hombre.IsChecked ? "Feo" : "Fea";

            if (Extravagante.IsChecked)
                extravagante = Hombre.IsChecked ? "Extravagante" : "Extravagante";

            if (Grande.IsChecked)
                grande = Hombre.IsChecked ? "Grande" : "Grande";

            List<string> adjetivos = new List<string>
            {
                alto,
                listo,
                raro,
                feo,
                extravagante,
                grande
            }.Where(adj => adj != null).ToList();

            string datasos = $"{nombre} es: ";

            int adjetivosCant = adjetivos.Count;

            for (int x = 0; x < adjetivosCant; x++)
            {
                datasos += adjetivos[x];

                if (x < adjetivosCant - 2)
                {
                    datasos += ", ";
                }
                else if (x == adjetivosCant - 2)
                {
                    datasos += " y ";
                }
            }

            //Datos.Text = datasos;
            DisplayAlert($"Datos de {nombre}", datasos, "OK");
        }

    }
}