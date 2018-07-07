using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels
{
    class DatosReferenciaVM
    {
        public List<Preguntas> Referencia
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Telefono Referencia 1",
                        Keyboard = Keyboard.Telephone
                    },

                    new Preguntas()
                    {
                        Concepto = "Telefono Referencia 2",
                        Keyboard = Keyboard.Telephone
                    },


                    new Preguntas()
                    {
                        Concepto = "Telefono Referencia",
                        Keyboard = Keyboard.Telephone
                    },


                    new Preguntas()
                    {
                        Concepto = "Estatus Muestra",
                        Keyboard = Keyboard.Text
                    },


                    new Preguntas()
                    {
                        Concepto = "Gastos",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Observaciones",
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
