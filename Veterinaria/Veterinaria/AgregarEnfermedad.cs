using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class AgregarEnfermedad
    {
        private int id;
        private string sintomas;
        private string alergias;
        private string detalles;
        private string enfermedad;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Enfermedad
        {
            get { return enfermedad; }
            set { enfermedad = value; }
        }
        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
        public string Sintomas
        {
            get { return sintomas; }
            set { sintomas = value; }
        }
        public string Alergias
        {
            get { return alergias; }
            set { alergias = value; }
        }
    }
}
