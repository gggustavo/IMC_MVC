using System;

namespace Modelo
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int Dni { get; set; }
        public string Domicilio { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }

        public abstract string CalcularImc(Atencion atencion);
    }
}
