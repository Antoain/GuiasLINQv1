using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Habitante' dentro del espacio de nombres 'IntroduccionLinq'
    public class Habitante
    {
        // Propiedad 'IdHabitante' que almacena un identificador único para cada habitante
        public int IdHabitante { get; set; }

        // Propiedad 'Nombre' que almacena el nombre del habitante
        public string Nombre { get; set; }

        // Propiedad 'Edad' que almacena la edad del habitante
        public int Edad { get; set; }

        // Propiedad 'IdCasa' que almacena el identificador de la casa en la que vive el habitante
        public int IdCasa { get; set; }

        // Método 'datosHabitante' que devuelve una cadena con los datos más importantes del habitante
        public string datosHabitante()
        {
            // Devuelve una descripción del habitante, incluyendo su nombre, edad y el identificador de la casa donde vive
            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
        }
    }
}
