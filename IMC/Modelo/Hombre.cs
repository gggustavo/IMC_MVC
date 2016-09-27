using System;

namespace Modelo
{
    public class Hombre : Persona
    {
        public override string CalcularImc(Atencion atencion)
        {
            var imc = Math.Round(atencion.Peso / (atencion.Altura * atencion.Altura));
            return Math.Abs(imc - 17) < 1
                ? "Desnutrición"
                : (imc >= 18 && imc <= 19
                    ? "Bajo Peso"
                    : (imc >= 21 && imc <= 25
                        ? "Normal"
                        : (imc >= 26 && imc <= 30
                            ? "Sobrepeso"
                            : (imc >= 31 && imc <= 35
                                ? "Obesidad"
                                : (imc >= 36 && imc <= 40
                                    ? "Obesidad Marcada"
                                    : (imc >= 40 ? "Obesidad Mórbida" : string.Empty))))));
        }
    }
}
