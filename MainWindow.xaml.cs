using System;
using System.Collections.Generic;
using System.Data;
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

namespace Tablitas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            TablaRegistros.ItemsSource = Registro.GetRegistros();
            //TablaRegistros.Columns[0].IsReadOnly = true;
            //TablaRegistros.Columns[0].IsReadOnly = false;
            

        }




        public class Registro
        {
            public String NumRegistro { get; set; }
            public String Nombre1 { get; set; }
            public String Nombre2 { get; set; }
            public String Nombre3 { get; set; }

            public Registro(String numRegistro, String n1, String n2, String n3)
            {
                this.NumRegistro = numRegistro;
                this.Nombre1 = n1;
                this.Nombre2 = n2;
                this.Nombre3 = n3;
            }

            public static List<Registro> GetRegistros()
            {
                return new List<Registro>(new Registro[32] {
                    new Registro ("R0"," "," "," "),
                    new Registro ("R1"," "," "," "),
                    new Registro ("R2"," "," "," "),
                    new Registro ("R3"," "," "," "),
                    new Registro ("R4"," "," "," "),
                    new Registro ("R5"," "," "," "),
                    new Registro ("R6"," "," "," "),
                    new Registro ("R7"," "," "," "),
                    new Registro ("R8"," "," "," "),
                    new Registro ("R9"," "," "," "),
                    new Registro ("R10"," "," "," "),
                    new Registro ("R11"," "," "," "),
                    new Registro ("R12"," "," "," "),
                    new Registro ("R13"," "," "," "),
                    new Registro ("R14"," "," "," "),
                    new Registro ("R15"," "," "," "),
                    new Registro ("R16"," "," "," "),
                    new Registro ("R17"," "," "," "),
                    new Registro ("R18"," "," "," "),
                    new Registro ("R19"," "," "," "),
                    new Registro ("R20"," "," "," "),
                    new Registro ("R21"," "," "," "),
                    new Registro ("R22"," "," "," "),
                    new Registro ("R23"," "," "," "),
                    new Registro ("R24"," "," "," "),
                    new Registro ("R25"," "," "," "),
                    new Registro ("R26"," "," "," "),
                    new Registro ("R27"," "," "," "),
                    new Registro ("R28"," "," "," "),
                    new Registro ("R29"," "," "," "),
                    new Registro ("R30"," "," "," "),
                    new Registro ("R31"," "," "," ")
                }); 
            }
        }

        private void SoloLeer(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.Header.ToString()=="NumRegistro")
            {
                e.Column.IsReadOnly = true;
            }
        }

        

    }
}
