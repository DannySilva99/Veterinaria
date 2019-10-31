using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class AgregarMascota
    {
        private int id;
        private string nombre;
        private string nombredueno;
        private string tipomascota;
        private string raza;
        private int edad;
        private DateTime horaydiacita;
        private string alergias;
        private int peso;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string NombreDueno
        {
            get { return nombredueno; }
            set { nombredueno = value; }
        }
        public string TipoMascota
        {
            get { return tipomascota; }
            set { tipomascota = value; }
        }
        public string Raza
        {
            get { return raza; }
            set { raza = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public DateTime HoraYDiaCita
        {
            get { return horaydiacita; }
            set { horaydiacita = value; }
        }
        public string Alergias
        {
            get { return alergias; }
            set { alergias = value; }
        }
        public int Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }
}
