using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.ComponentModel;

namespace Dominio
{
    public class Articulo
    {
       public int Id { get; set; }
       [DisplayName("Código")]
        public string Codigo { get; set; }
       
       public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

       public string UrlImagen { get; set; }
    
       public int IdCategoria { get; set; }

       public int IdMarca { get; set; }
        [DisplayName("Marca")]
        public Marca marca { get; set; }
        [DisplayName("Categoría")]
        public Categoria categoria { get; set; }
    
       public decimal Precio { get; set; }
    }
}
