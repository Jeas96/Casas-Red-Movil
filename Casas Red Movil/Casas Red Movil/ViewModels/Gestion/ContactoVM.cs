using Casas_Red_Movil.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Casas_Red_Movil.ViewModels.Gestion
{
    class ContactoVM
    {
        public List<Preguntas> Contacto
        {
            get
            {
                return new List<Preguntas>() {
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
                        Concepto = "Telefono de Trabajo",
                        Keyboard = Keyboard.Telephone
                    },
                    new Preguntas()
                    {
                        Concepto = "Correo Electronico",
                        Keyboard = Keyboard.Email
                    },
                };
            }
        }
    }
}
