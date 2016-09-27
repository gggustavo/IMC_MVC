using System.Linq;
using Modelo;

namespace Controladora
{
    public class AtencionController
    {
        public void Agregar(Modelo.Atencion atencion)
        {
            Testing();

            var context = SingletonContext.GetContext();

            context.Atenciones.Add(atencion);
            context.SaveChanges();
        }

        private void Testing()
        {
            var context = SingletonContext.GetContext();

            //var hombres = context.Hombres.ToList();

            //var personas = context.Personas.OfType<Hombre>().ToList();

            var atencion = context.Atenciones.Include("Persona")
                                             .Include("Medico").AsNoTracking().ToList();


        }
    }
}
