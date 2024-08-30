using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionLinq
{
    // Definición de la clase 'Casa' dentro del espacio de nombres 'IntroduccionLinq'
    public class Casa
    {
        // Propiedad 'Id' para almacenar un identificador único para cada casa
        public int Id { get; set; }

        // Propiedad 'Direccion' para almacenar la dirección de la casa
        public string Direccion { get; set; }

        // Propiedad 'Ciudad' para almacenar la ciudad donde se encuentra la casa
        public string Ciudad { get; set; }

        // Propiedad 'numeroHabitaciones' para almacenar el número de habitaciones en la casa
        public int numeroHabitaciones { get; set; }

        // Método 'dameDatosCasa' que devuelve una cadena con los datos más importantes de la casa
        public string dameDatosCasa()
        {
            // Devuelve una descripción de la casa, incluyendo su dirección, ciudad y número de habitaciones
            return $"Dirección es {Direccion} en la ciudad de {Ciudad} con número de habitaciones {numeroHabitaciones}";
        }
    }
}
