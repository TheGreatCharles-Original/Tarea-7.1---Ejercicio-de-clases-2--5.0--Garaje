using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using Tarea_7._1___Ejercicio_de_clases_2__5._0__Garaje.Clases.Clases;

namespace Tarea_7._1___Ejercicio_de_clases_2__5._0__Garaje.Clases.Clases
{
    internal class Program
    {
    static void Main(string[] args)
        {
            Garaje TooHardd = new Garaje(); // Se intancia para poder llamar a cosas del Garage

            TooHardd.Informacion();
            ReadLine();

        }
    }
}
//Tarea_7._1___Ejercicio_de_clases_2__5._0__Garaje.Clases