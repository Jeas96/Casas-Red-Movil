using Casas_Red_Movil.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class DireccionVM
    {
        public List<Preguntas> Direccion
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Calle",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "NUmero",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Codigo Postal",
                        Keyboard = Keyboard.Numeric
                    },
                    new Preguntas()
                    {
                        Concepto = "Colonia",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Municipio",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Estado",
                        Keyboard = Keyboard.Text
                    },
                };
            }
        }
    }
}
