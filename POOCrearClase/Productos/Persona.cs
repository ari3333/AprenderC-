using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POOCrearClase.Productos
{
    class Persona
    {
        private string nombre;
        private string nid;
        string pais;

        //te posicionas al lado de la propiedad y con ctrl + . te sale el metodo entero
        public string Nombre { 
            get => nombre; 
            set => nombre = value; 
        }
        //public string Nid { get => nid; set => nid = value; }
        //public string Pais { get => pais; set => pais = value; }

        //crear nuestros propios get y set
        public string Pais
        {
            get
            {
                 return "Mi pais es: " + pais;
            }
            set { pais = value; }
        }

        //manera mas corta de hacerlo
        public string Nid { get; set; }
    }
}
