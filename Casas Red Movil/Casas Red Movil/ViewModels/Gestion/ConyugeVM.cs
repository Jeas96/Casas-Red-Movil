using Casas_Red_Movil.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class ConyugeVM
    {
        public List<Preguntas> Conyuge
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Nombre",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Apellido Paterno",
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
                        Concepto = "No. Seguro Social",
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
                        Concepto = "Celular",
                        Keyboard = Keyboard.Telephone
                    },
                    new Preguntas()
                    {
                        Concepto = "Telefono de Casa",
                        Keyboard = Keyboard.Telephone
                    },
                    new Preguntas()
                    {
                        Concepto = "Ocupacion",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Telefono de Trabajo",
                        Keyboard = Keyboard.Telephone
                    },

                    new Preguntas()
                    {
                        Concepto = "Correo Electronico",
                        Keyboard = Keyboard.Email
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
