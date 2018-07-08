using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class DatosGeneralesVM
    {
        public List<Preguntas> DatosGenerales
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Fecha de Alta",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Nombre",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "APellido Paterno",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Apellido Materno",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Fecha de Nacimiento",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "CURP",
                        Keyboard = Keyboard.Text
                    },

                    new Preguntas()
                    {
                        Concepto = "RFC",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Lugar de Nacimiento",
                        Keyboard = Keyboard.Text
                    },

                    new Preguntas()
                    {
                        Concepto = "CURP",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Lugar de Nacimiento",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Regimen Matrimonial",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Ocupacion",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Numero de Identificacion",
                        Keyboard = Keyboard.Numeric
                    },
                };
            }
        }
    }
}
