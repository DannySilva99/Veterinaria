using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class RepoEnfermedades
    {
        int Opc;
        List<AgregarEnfermedad> ListaDeEnfermedades = new List<AgregarEnfermedad>();

        public void CrearEnfermedad()
        {
            AgregarEnfermedad NuevaEnfermedad = new AgregarEnfermedad();
            Console.WriteLine("Sintomas de su mascota: ");
            NuevaEnfermedad.Sintomas = Console.ReadLine();
            Console.WriteLine("Su mascota tiene alergias? ");
            Console.WriteLine("1.-Si ");
            Console.WriteLine("2.-No ");
            Opc = Convert.ToInt32(Console.ReadLine());
            if (Opc == 1)
            {
                Console.WriteLine("A que es alergica su mascota? ");
                NuevaEnfermedad.Alergias = Console.ReadLine();
            }
            else if (Opc == 2) 
            {
                Console.WriteLine("Ninguna");
                NuevaEnfermedad.Alergias = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Introduzca una opcion valida ");
            }
            Console.WriteLine("La enfermedad de su mascota es: ");
            NuevaEnfermedad.Enfermedad = Console.ReadLine();
            Console.WriteLine("Detalles de la enfermedad: ");
            Console.ReadKey();
            ListaDeEnfermedades.Add(NuevaEnfermedad);
            Console.Clear();
        }
        public void ListarEnfermedades()
        {
            foreach (AgregarEnfermedad NE in ListaDeEnfermedades)
            {
                Console.WriteLine("Su mascota tiene: " + NE.Enfermedad);
                Console.WriteLine("Sintomas de la enfermedad:  " + NE.Sintomas);
                Console.WriteLine("Alergias de la mascota: " + NE.Alergias);
                Console.WriteLine("Detalles de la enfermedad: "+NE.Detalles);
                Console.ReadKey();
            }
        }
    }
}
