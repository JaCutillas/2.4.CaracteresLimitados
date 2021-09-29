using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextoActualizadoPrincipalTextBox(Object sender, TextChangedEventArgs args)

        {
            int numeroCaracteres = PrincipalTextBox.Text.ToCharArray().Length;

            if (numeroCaracteres >= 140) 
            {
                PrincipalTextBox.IsReadOnly = true;
                DarEnhorabuena();
            }
            
            ContadorTextBlock.Text = numeroCaracteres + "/140";
        }

        private void DarEnhorabuena()
        {
            MensajeTextBlock.Text = "";
        }
    }
}
