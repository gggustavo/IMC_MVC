using System;

namespace Modelo
{
    public class Mujer : Persona
    {
        public override string CalcularImc(Atencion atencion)
        {
            var imc = Math.Round(atencion.Peso / (atencion.Altura * atencion.Altura));

            return Math.Abs(imc - 16) < 1
                ? "Desnutrición"
                : (imc >= 17 && imc <= 20
                    ? "Bajo Peso"
                    : (imc >= 21 && imc <= 24
                        ? "Normal"
                        : (imc >= 25 && imc <= 29
                            ? "Sobrepeso"
                            : (imc >= 30 && imc <= 34
                                ? "Obesidad"
                                : (imc >= 35 && imc <= 39
                                    ? "Obesidad Marcada"
                                    : (imc >= 40 ? "Obesidad Mórbida" : string.Empty))))));
        }
    }
}
