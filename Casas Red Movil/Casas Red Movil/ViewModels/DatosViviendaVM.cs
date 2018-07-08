using Casas_Red_Movil.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels
{
    class DatosViviendaVM
    {
        public List<Preguntas> DatosVivienda
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Direccion",
                        Keyboard = Keyboard.Text
                    },

                    new Preguntas()
                    {
                        Concepto = "Precio",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Gasto",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Tipo Vivienda",
                        Keyboard = Keyboard.Text
                    },


                    new Preguntas()
                    {
                        Concepto = "Año Compra",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Clave Predial",
                        Keyboard = Keyboard.Text
                    },


                    new Preguntas()
                    {
                        Concepto = "Numero de Celular",
                        Keyboard = Keyboard.Telephone
                    },


                    new Preguntas()
                    {
                        Concepto = "Clave Catastral",
                        Keyboard = Keyboard.Telephone
                    },

                };
            }
        }
    }
}
