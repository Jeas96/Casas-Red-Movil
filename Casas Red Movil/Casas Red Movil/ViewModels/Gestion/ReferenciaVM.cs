using Casas_Red_Movil.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class ReferenciaVM
    {
        public List<Preguntas> Referencia
        {
            get
            {
                return new List<Preguntas>() {
                    new Preguntas()
                    {
                        Concepto = "Nombre Referencia",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Celular de Referencia",
                        Keyboard = Keyboard.Telephone
                    },
                    new Preguntas()
                    {
                        Concepto = "Nombre Referencia 2",
                        Keyboard = Keyboard.Text
                    },
                    new Preguntas()
                    {
                        Concepto = "Celuar Referencia 2",
                        Keyboard = Keyboard.Telephone
                    },
                };
            }
        }
    }
}
