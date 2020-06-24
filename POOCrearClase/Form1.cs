using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOCrearClase.Productos;
using Productos;

namespace POOCrearClase
{

    public partial class Form1 : Form
    {
        // Telefono Movistar = new Telefono();//objeto creado
        //Telefono Claro = new Telefono("Samsung");
        //Telefono kolby = new Telefono("Samsung","Rojo","Normal");
        Persona p = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        /* 
         * private void btn_llamar_Click(object sender, EventArgs e)
          {
              //Movistar.llamar();

              MessageBox.Show(Movistar.mandarMensaje("Arianny", "Hola que tal?"));

              MessageBox.Show(Operaciones.suma(2, 4).ToString());

          }

          */

        private void btn_llamar_Click(object sender, EventArgs e)
        {
            p.Pais = "Cuba";
            p.Nid = "674774grhed";
            MessageBox.Show(p.Nid);
        }
    }
}
