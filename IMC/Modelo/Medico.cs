﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Medico : Persona
    {
        public int Matricula { get; set; }

        public override string CalcularImc(Atencion atencion)
        {
            throw new NotImplementedException();
        }
    }
}
