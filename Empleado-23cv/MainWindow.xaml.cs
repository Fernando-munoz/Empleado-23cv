using Empleado_23cv.Entities;
using Empleado_23cv.Services;
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

namespace Empleado_23cv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //instaNCIAMOS al empleado en la variable empl 
        Empleado empl = new Empleado();
        EmpleadosServices services = new EmpleadosServices();

        private void Btn_Agregar_Click_1(object sender, RoutedEventArgs e)
        {

               
                empl.Nombre = txtNombre.Text;
                empl.Apellido = txtApellido.Text;
                empl.Correo = txtCorreo.Text;
            
            
            
            


            if (txtNombre.Text =="" || txtApellido.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("hacen falta campos por llenar");

            }


            services.Add(empl);

            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            MessageBox.Show("los datos se guardaron correctamente");



        }

        private void Btn_Ver_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtID.Text);
            Empleado empl = services.Read(id);


            txtNombre.Text = empl.Nombre;
            txtApellido.Text = empl.Apellido;
            txtCorreo.Text = empl.Correo;
            txtfecha.Text = empl.FechaRegistro.ToString();
          
        }
    }
}
