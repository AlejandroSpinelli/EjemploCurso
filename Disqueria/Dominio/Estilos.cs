using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estilos
    {
        public override string ToString()
        {
            return Descripcion;
        }


        public int id {  get; set; }
        public string Descripcion {  get; set; }


    }
}
