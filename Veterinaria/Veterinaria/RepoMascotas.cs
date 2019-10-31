using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class RepoMascotas
    {
        int Opc;
        List<AgregarMascota> ListaDeMascotas = new List<AgregarMascota>();

        public void CrearMascota()
        {
            AgregarMascota NuevaMascota = new AgregarMascota();
            Console.WriteLine("Nombre de la mascota: ");
            NuevaMascota.Nombre = Console.ReadLine();
            Console.WriteLine("Nombre del dueño de la mascota: ");
            NuevaMascota.NombreDueno = Console.ReadLine();
            Console.WriteLine("Tipo de mascota: ");
            NuevaMascota.TipoMascota = Console.ReadLine();
            Console.WriteLine("Raza de la mascota: ");
            NuevaMascota.Raza = Console.ReadLine();
            Console.WriteLine("Edad de la mascota: ");
            NuevaMascota.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dia y hora en que se realizara la cita: ");
            NuevaMascota.HoraYDiaCita = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Peso de su mascota: ");
            NuevaMascota.Peso = Convert.ToInt32(Console.ReadLine());           
            Console.ReadKey();
            ListaDeMascotas.Add(NuevaMascota);
            Console.Clear();
        }
        public void ListarMascotas()
        {
            foreach (AgregarMascota NM in ListaDeMascotas)
            {
                Console.WriteLine("Nombre de la mascota:" + NM.Nombre);
                Console.WriteLine("Nombre del dueño de la mascota: " + NM.NombreDueno);
                Console.WriteLine("Tipo de mascota: " + NM.TipoMascota);
                Console.WriteLine("Raza de la mascota: " + NM.Raza);
                Console.WriteLine("Edad de la mascota: " + NM.Edad);
                Console.WriteLine("Hora y dia de la cita: " + NM.HoraYDiaCita);
                Console.ReadKey();
            }
        }       
    }
}
