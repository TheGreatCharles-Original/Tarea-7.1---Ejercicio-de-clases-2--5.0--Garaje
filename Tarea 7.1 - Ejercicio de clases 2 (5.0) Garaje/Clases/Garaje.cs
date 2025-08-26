using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea_7._1___Ejercicio_de_clases_2__5._0__Garaje.Clases.Clases
{
    public class Garaje 
    {
        private double NumGaraje { get; set; }
        private string Descripcion { get; set; }
        private double Capacidad { get; set; }
        private double Ocupado { get; set; }

        public Garaje() // Constructor para inicializar
        {
            NumGaraje = 1;
            Descripcion = "Garaje Casi lleno";
            Capacidad = 99;
            Ocupado = 9;
        }

        public Garaje(double capacidad, double ocupado) // Constructor para asignar datos y poder hacer la resta
        {

            Capacidad = capacidad;
            Ocupado = ocupado;
        }

        public double Disponibles() //Metodo
        {
            return Capacidad - Ocupado;
        }

        public void Informacion()
        {
            WriteLine($"Número de Garaje: {NumGaraje}"); // Interpolacion
            WriteLine($"Descripción: {Descripcion}");
            WriteLine($"Capacidad: {Capacidad}");
            WriteLine($"Ocupado: {Ocupado}");
            WriteLine($"Espacio Disponible: {Capacidad - Ocupado}");
        }
    }
}


//Dentro de la carpeta Clases cree la Clase Garaje con los siguientes atributos: número de garaje, descripción, capacidad de espacios, espacios ocupados. Cree un constructor para inicializar todas las variables.