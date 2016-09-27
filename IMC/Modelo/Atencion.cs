using System;

namespace Modelo
{
    public class Atencion
    {
        public int IdAtencion { get; set; }

        public Persona Persona { get; set; }
        public Medico Medico { get; set; }
        public DateTime Fecha { get; set; }
        public string Imc { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
    }
}
