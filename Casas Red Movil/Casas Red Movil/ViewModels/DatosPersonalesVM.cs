using Casas_Red_Movil.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels
{
    class DatosPersonalesVM
    {
        public List<Preguntas> DatosPersonales
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Estatus",
                        Keyboard = Keyboard.Text
                    },

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
                        Concepto = "Fecha Nacimiento",
                        Keyboard = Keyboard.Text
                    },


                    new Preguntas()
                    {
                        Concepto = "Estado Civil",
                        Keyboard = Keyboard.Text
                    },


                    new Preguntas()
                    {
                        Concepto = "Numero de Celular",
                        Keyboard = Keyboard.Telephone
                    },


                    new Preguntas()
                    {
                        Concepto = "Telefono de Casa",
                        Keyboard = Keyboard.Telephone
                    },


                    new Preguntas()
                    {
                        Concepto = "Telefono de Trabajo",
                        Keyboard = Keyboard.Telephone
                    },

                };
            }
        }
    }
}
