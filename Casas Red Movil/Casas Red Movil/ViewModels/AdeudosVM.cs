using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels
{
    class AdeudosVM
    {
        public List<Preguntas> Adeudos
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Saldo Infonavit",
                        Keyboard = Keyboard.Numeric
                    },

                    new Preguntas()
                    {
                        Concepto = "Adeudo Luz",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Adeudo Predial",
                        Keyboard = Keyboard.Numeric
                    },


                    new Preguntas()
                    {
                        Concepto = "Adeudo Agua",
                        Keyboard = Keyboard.Numeric
                    },

                };
            }
        }
    }
}
