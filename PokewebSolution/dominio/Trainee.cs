using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Trainee
    {
        public int id {  get; set; }
        public string user {  get; set; }  
        public string pass { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string urlImagen { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public bool admin {  get; set; }    
    }
}
