using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var controller = new AtencionController();

            var medico = new Modelo.Medico
            {
              Dni = 31535256,
              Domicilio = "Rosario",
              Email = "imc@imc.com",
              FechaNacimiento = DateTime.Now,
              Matricula = 23456,
              Nombre = "Medico"
            };

            var hombre = new Modelo.Hombre
            {
                Nombre = "Hombre",
                Dni = 31456345,
                Domicilio = "Rosario",
                Email = "email@email.com",
                FechaNacimiento = DateTime.Now,
                Telefono = 341345622
            };

            var atencion = new Modelo.Atencion
            {
                Persona = hombre,
                Medico = medico,
                Fecha = DateTime.Now,
                Peso = 75,
                Altura = float.Parse("1.9")            
            };


            atencion.Imc = hombre.CalcularImc(atencion);

            controller.Agregar(atencion);

            base.OnLoad(e);
        }
    }
}
