namespace IntroduccionLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de las listas
            List<Casa> ListaCasas = new List<Casa>();
            List<Habitante> ListaHabitantes = new List<Habitante>();

            // Llenar la lista de casas con ejemplos de casas
            ListaCasas.Add(new Casa
            {
                Id = 1,
                Direccion = "3 av Norte ArcanCity",
                Ciudad = "Gothan City",
                numeroHabitaciones = 20
            });

            ListaCasas.Add(new Casa
            {
                Id = 2,
                Direccion = "6 av Sur SmollVille",
                Ciudad = "Metropolis",
                numeroHabitaciones = 5
            });

            ListaCasas.Add(new Casa
            {
                Id = 3,
                Direccion = "Forest Hills, Queens, NY 11375",
                Ciudad = "New York"
            });

            // Llenar la lista de habitantes con ejemplos de habitantes
            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 1,
                Nombre = "Bruno Diaz",
                Edad = 36,
                IdCasa = 1
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 2,
                Nombre = "Clark Kent",
                Edad = 40,
                IdCasa = 2
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 3,
                Nombre = "Peter Parker",
                Edad = 25,
                IdCasa = 3
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 4,
                Nombre = "Tia Mey",
                Edad = 85,
                IdCasa = 3
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 5,
                Nombre = "Luise Lain",
                Edad = 40,
                IdCasa = 2
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 6,
                Nombre = "Selina Kyle",
                Edad = 30,
                IdCasa = 1
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 7,
                Nombre = "Alfred",
                Edad = 36,
                IdCasa = 1
            });

            ListaHabitantes.Add(new Habitante
            {
                IdHabitante = 8,
                Nombre = "Nathan Drake",
                Edad = 36,
                IdCasa = 1
            });

            // Consultas con Where para filtrar habitantes con edad mayor a 30 años
            IEnumerable<Habitante> ListaEdad = from ObjetoProvicional in ListaHabitantes
                                               where ObjetoProvicional.Edad > 30
                                               select ObjetoProvicional;

            Console.WriteLine("Habitantes con edad mayor a 30 años:");
            foreach (Habitante objetoProcicional2 in ListaEdad)
            {
                Console.WriteLine(objetoProcicional2.datosHabitante());
            }

            // Consultas con Join para encontrar habitantes que viven en Gothan City
            IEnumerable<Habitante> listaCasaGothan = from objetoTemporalHabitante in ListaHabitantes
                                                     join objetoTemporalCasa in ListaCasas
                                                     on objetoTemporalHabitante.IdCasa equals objetoTemporalCasa.Id
                                                     where objetoTemporalCasa.Ciudad == "Gothan City"
                                                     select objetoTemporalHabitante;

            Console.WriteLine("\nHabitantes de Gothan City:");
            foreach (Habitante h in listaCasaGothan)
            {
                Console.WriteLine(h.datosHabitante());
            }


            #region FirsthAndFirsthOrDefault
            // Ejemplo comentado de cómo usar First y FirstOrDefault en LINQ
            /*
            var primeraCasa = ListaCasas.First(); // Método de Enumerable, no LINQ
            Console.WriteLine(primeraCasa.dameDatosCasa());

            // Aplicación de First con restricción sin usar lambdas
            Habitante personaEdad = (from variableTemporalHabitante in ListaHabitantes where variableTemporalHabitante.Edad > 25 select variableTemporalHabitante).First();
            Console.WriteLine(personaEdad.datosHabitante());

            // Usando First con expresión lambda
            var Habitante1 = ListaHabitantes.First(objectTemp => objectTemp.Edad > 25);
            Console.WriteLine(Habitante1.datosHabitante());

            // Uso de FirstOrDefault para evitar excepciones cuando no se encuentra un elemento
            Casa CasaConFirsthOrDedault = ListaCasas.FirstOrDefault(vCasa => vCasa.Id > 200);
            if (CasaConFirsthOrDedault == null) {
                Console.WriteLine("No existe! No hay!");
                return;
            }
            Console.WriteLine("existe! ¡Sí existe!");
            */
            #endregion


            #region Last
            // Ejemplo comentado de cómo usar Last y LastOrDefault en LINQ
            /*
            Casa ultimaCasa = ListaCasas.Last(temp => temp.Id > 1);
            Console.WriteLine(ultimaCasa.dameDatosCasa());

            var h1 = (from objHabitante in ListaHabitantes where objHabitante.Edad > 60 select objHabitante).LastOrDefault();
            if (h1 == null)
            {
                Console.WriteLine("Algo falló");
                return;
            }
            Console.WriteLine(h1.datosHabitante());
            */
            #endregion

            #region element
            // Uso de ElementAt y ElementAtOrDefault para obtener elementos por su posición en la lista
            var terceraCasa = ListaCasas.ElementAt(2);
            Console.WriteLine($"La tercera casa es {terceraCasa.dameDatosCasa()}");

            var casaError = ListaCasas.ElementAtOrDefault(3);
            if (casaError != null) { Console.WriteLine($"La cuarta casa es {casaError.dameDatosCasa()}"); }

            var segundoHabitante = (from objetoTem in ListaHabitantes select objetoTem).ElementAtOrDefault(2);
            Console.WriteLine($"El segundo habitante es: {segundoHabitante.datosHabitante()}");
            #endregion


            #region Single
            // Uso de Single y SingleOrDefault para obtener un único elemento que cumple una condición
            try
            {
                var habitantes = ListaHabitantes.Single(variableTem => variableTem.Edad > 40 && variableTem.Edad < 70);

                var habitante2 = (from obtem in ListaHabitantes where obtem.Edad > 70 select obtem).SingleOrDefault();

                Console.WriteLine($"Habitante con edad entre 40 y 70 años: {habitantes.datosHabitante()}");
                if (habitante2 != null) Console.WriteLine($"Habitante con más de 70 años: {habitante2.datosHabitante()}");
            }
            catch (Exception)
            {
                Console.WriteLine($"Ocurrió un error");
            }
            #endregion

            #region typeOf
            // Uso de OfType para filtrar elementos de un tipo específico en una lista heterogénea
            var listaEmpleados = new List<Empleado>() {
                new Medico(){ nombre = "Jorge Casa" },
                new Enfermero(){ nombre = "Raul Blanco"}
            };

            var medico = listaEmpleados.OfType<Medico>();
            Console.WriteLine(medico.Single().nombre);
            #endregion

            #region OrderBYDescending()
            // Ejemplo comentado de cómo ordenar en orden descendente usando LINQ y lambdas
            /*
            var listaEdad = ListaHabitantes.OrderByDescending(x => x.Edad);
            foreach (Habitante h in listaEdad) { 
                Console.WriteLine(h.datosHabitante());
            }
            
            var ListaEdad2 = from h in ListaHabitantes orderby h.Edad descending select h;
            foreach (Habitante h in ListaEdad2)
            {
                Console.WriteLine(h.datosHabitante());  
            }
            */
            #endregion

            #region Thenby
            // Uso de ThenBy y ThenByDescending para realizar ordenaciones secundarias
            var habitantes3 = ListaHabitantes.OrderBy(x => x.Edad).ThenBy(x => x.Nombre);

            foreach (var h in habitantes3)
            {
                Console.WriteLine(h.datosHabitante());
            }

            var edadATA = from h in ListaHabitantes orderby h.Edad, h.Nombre descending select h;

            foreach (var h in edadATA)
            {
                Console.WriteLine(h.datosHabitante());
            }

            Console.WriteLine("------------------");

            var habitantes4 = ListaHabitantes.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

            foreach (var h in habitantes4)
            {
                Console.WriteLine(h.datosHabitante());
            }

            var lista4 = from h in ListaHabitantes orderby h.Edad, h.Nombre ascending select h;

            foreach (var h in lista4)
            {
                Console.WriteLine(h.datosHabitante());
            }
            #endregion
        }
    }
}
