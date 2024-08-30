using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // La clase 'Medico' hereda de la clase 'Empleado'
    public class Medico : Empleado
    {
        // Propiedad 'nombre' para almacenar el nombre del médico
        public string nombre { get; set; }
    }
}
