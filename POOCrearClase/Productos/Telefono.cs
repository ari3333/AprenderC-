using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos
{
    public class Telefono
    {
        //propiedades
        private string marca;
        private string color;
        private string tipo;

        public Telefono()
        {
            marca = "Huawei";
            color = "Blanco";
            tipo = "Plegable";
        }

        public Telefono(string M)
        {
            marca = M;
            color = "Blanco";
            tipo = "Normal";
        }

        public Telefono(string M, string C, string T)
        {
            marca = M;
            color = C;
            tipo = T;
        }

        //metodo
        public void llamar()
        {
            System.Windows.Forms.MessageBox.Show("Tu celular es un:" + marca+ " y es de color: "+ color+ ", con tipo "+ tipo);
        }

        public string mandarMensaje(string nom, string msj)
        {
            string nombre = nom;
            string mensaje = msj;

            string enviando = "El mensaje: " + mensaje + ", enviado por: " + nombre;
            
            return enviando;
        }

    }
}
