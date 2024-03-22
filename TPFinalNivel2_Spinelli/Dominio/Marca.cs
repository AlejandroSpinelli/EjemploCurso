using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public override string ToString()
        {
            return Descripcion;
        }

        public int Id { get; set; }

        public string Descripcion { get; set; }
    }
}
