using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica3DMM_DLL.View;

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

        private void Guardar(object sender, EventArgs e) 
        {
            string Nombre;
            bool radioHombre;
            bool radioMujer;
            bool checkAlto;
            bool checkListo;
            bool checkRaro;
            bool checkFeo;
            bool checkExtravagante;
            bool checkGrande;
        }
    
    }
}